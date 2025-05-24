using APBD_CW5.DAL;
using APBD_CW5.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_CW5;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddAuthorization();

        builder.Services.AddOpenApi();
        builder.Services.AddControllers();
        builder.Services.AddDbContext<Hospital>(o =>
        {
            o.UseSqlServer(connectionString);
        }
    );


    var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.MapControllers();

        

        app.Run();
    }
}