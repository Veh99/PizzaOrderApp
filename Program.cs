using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PizzaOrderApp.Database.Sqlite;
using PizzaOrderApp.Hubs;
using PizzaOrderApp.Infrastraction;
using PizzaOrderApp.Interfaces;
using PizzaOrderApp.Repositories;
using System.Text;

namespace PizzaOrderApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<OrdersRepository>();
            builder.Services.AddScoped<PizzaRepository>();
            builder.Services.AddScoped<JwtProvider>();
            builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

            builder.Services.AddSignalR(options =>
            {
                options.ClientTimeoutInterval = TimeSpan.FromSeconds(60);
                options.MaximumReceiveMessageSize = 1024;
                options.EnableDetailedErrors = true;
            });

            builder.Services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString(nameof(ApplicationDbContext)));
            });

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.TokenValidationParameters = new()
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("JwtOptions:SecretKey").Value!))
                    };

                    options.Events = new JwtBearerEvents()
                    {
                        OnMessageReceived = context =>
                        {
                            context.Token = context.Request.Cookies["COOKIES"];

                            return Task.CompletedTask;
                        }
                    };
                });
            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.MapHub<ChatHub>("/chat", options =>
            {
                options.AllowStatefulReconnects = true;
                options.TransportMaxBufferSize = 1024;
            });

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}