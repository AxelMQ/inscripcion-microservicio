using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts.Dtos.Gestion;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class GestionController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GestionController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GestionDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();
            var gestiones = await repo.GetAllAsync(ct);

            var dtos = _mapper.Map<IEnumerable<GestionDto>>(gestiones);
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GestionDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();
            var gestion = await repo.GetByIdAsync(id, ct);

            if (gestion is null) return NotFound();

            var dto = _mapper.Map<GestionDto>(gestion);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<GestionDto>> Create([FromBody] GestionCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Gestion>();
            var entity = _mapper.Map<Gestion>(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var responseDto = _mapper.Map<GestionDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] GestionUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Gestion>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            _mapper.Map(dto, existing);

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
