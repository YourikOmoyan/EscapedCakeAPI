using BLL.EscapedCake.Entities;
using BLL.EscapedCake.Services;
using DAL.EscapedCake.Entities;
using DAL.EscapedCake.Services;
using System.Data.Common;
using System.Data.SqlClient;

namespace EscapedCakeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<DbConnection>(sp => new SqlConnection(builder.Configuration.GetConnectionString("Database")));
            builder.Services.AddTransient<DProductService>();
            builder.Services.AddTransient<BProductService>();
            builder.Services.AddTransient<DCategoryService>();
            builder.Services.AddTransient<BCategoryService>();
            builder.Services.AddTransient<DUserService>();
            builder.Services.AddTransient<BUserService>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}