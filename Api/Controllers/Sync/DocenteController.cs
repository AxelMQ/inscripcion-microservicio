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
using Shared.Contracts.Dtos.Docente;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "sync")] 
    //[Authorize]
    public class DocenteController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public DocenteController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocenteDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var docentes = await repo.Query()
                .Include(d => d.HorariosMateria)
                .AsNoTracking()
                .ToListAsync(ct);

            var dtos = _mapper.Map<IEnumerable<DocenteDto>>(docentes);
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<DocenteDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var docente = await repo.Query()
                .Include(d => d.HorariosMateria)
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.Id == id, ct);

            if (docente is null) return NotFound();

            var dto = _mapper.Map<DocenteDto>(docente);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<DocenteDto>> Create([FromBody] DocenteCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Docente>();
            var entity = _mapper.Map<Docente>(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var responseDto = _mapper.Map<DocenteDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] DocenteUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Docente>();
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
            var repo = _uow.GetRepository<Docente>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
