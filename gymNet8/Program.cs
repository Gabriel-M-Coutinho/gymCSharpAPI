using Microsoft.OpenApi.Models;

namespace gymNet8;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Adicione os controladores
        builder.Services.AddControllers();

        // Configuração do Swagger com versão especificada
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "gymNet8 API",
                Version = "v1"
            });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "gymNet8 API v1");
                c.RoutePrefix = "swagger"; // Swagger UI será acessado via /swagger
            });
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}