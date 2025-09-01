using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddHealthChecks(builder.Configuration)
    .AddSwaggerDocumentation()
    .AddJwtAuthentication(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// ORDEN CLAVE
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseSwaggerAndSwaggerUI(app.Environment);

// Mapear endpoints
app.MapControllers();
app.MapCustomHealthChecks(); // 👈 ahora sí compila

app.Run();
