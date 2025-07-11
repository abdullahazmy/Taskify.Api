using BrainHope.Services.DTO.Email;
using Microsoft.AspNetCore.Identity;
using StackExchange.Redis;
using Taskify.DataAccess;
using Taskify.DataAccess.Contexts;
using Taskify.DataAccess.Models;
using Taskify.Infrastructure;
using Taskify.Services;
using Taskify.Services.Interfaces.Account;
using Taskify.Services.Services.AccountServices;
using Utilites;

namespace Taskify.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var config = builder.Configuration;

            // Inject external DI
            builder.Services
                .AddDataAccessServices(config)
                .AddServiceLayer()
                .AddInfrastructure(config)
                .AddApiLayer(config);

            // Identity config
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();



            #region Email
            var Configure = builder.Configuration;
            var emailconfig = Configure.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            builder.Services.AddSingleton(emailconfig);
            builder.Services.AddScoped<IEmailService, EmailService>();
            builder.Services.Configure<IdentityOptions>(opts => opts.SignIn.RequireConfirmedEmail = true);
            #endregion
            builder.Services.AddAuthorization();

            // Redis
            builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
            {
                var redisConnection = config.GetSection("Redis")["ConnectionString"];
                return ConnectionMultiplexer.Connect(redisConnection);
            });

            var app = builder.Build();

            // Redis ImageHelper Config
            var accessor = app.Services.GetRequiredService<IHttpContextAccessor>();
            var env = app.Services.GetRequiredService<IWebHostEnvironment>();
            ImageHelper.Configure(accessor, env);

            // Middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
