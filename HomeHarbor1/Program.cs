
using HomeHarbor1.Models;
using HomeHarbor1.Repositories_Booking;
using HomeHarbor1.Repositories_Feedback;
using HomeHarbor1.Repositories_Registration;
using HomeHarbor1.Repositories_Service;
using HomeHarbor1.Repositories_Slot;
using HomeHarbor1.Repositories_Status;
using HomeHarbor1.Services_Booking;
using HomeHarbor1.Services_Feedback;
using HomeHarbor1.Services_Registration;
using HomeHarbor1.Services_Service;
using HomeHarbor1.Services_Slot;
using HomeHarbor1.Services_Status;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.Contracts;
using System.Text;

namespace HomeHarbor1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IRegistrationRepository, RegistrationRepository>();
            builder.Services.AddTransient<IRegistrationService, RegistrationService>();
            builder.Services.AddTransient<ISlotRepository, SlotRepository>();
            builder.Services.AddTransient<ISlotService, SlotService>();
            builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
            builder.Services.AddTransient<IServiceService, ServiceService>();
            builder.Services.AddTransient<IBookingRepository, BookingRepository>();
            builder.Services.AddTransient<IBookingService, BookingService>();
            builder.Services.AddTransient<IFeedbackRepository, FeedbackRepository>();
            builder.Services.AddTransient<IFeedbackService, FeedbackService>();
            builder.Services.AddTransient<IStatusRepository, StatusRepository>();
            builder.Services.AddTransient<IStatusService, StatusService>();
            builder.Services.AddDbContext<HomeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon")));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("policy", builder => builder
                    .WithOrigins("http://localhost:3000")
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .AllowAnyHeader());
                // .WithHeaders("Accept", "Content-Type", "Origin", "X-My-Header"));
            });


            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],  //specifies valid issuer of token
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey
                    (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
                    ValidateIssuer = true,  //enables issuer validation
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true
                };

            });
            builder.Services.AddAuthorization();
            var app = builder.Build(); //This line builds the WebApplication instance.

            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection(); // adds middleware to the application’s pipeline that redirects HTTP requests to HTTPS.

            app.UseAuthorization();//adds authorization middleware to the application’s pipeline.

            app.UseCors("policy");
            app.MapControllers();//maps attribute-routed controllers to the application’s routing middleware.

            app.Run();//runs the application.
        }
    }
}
