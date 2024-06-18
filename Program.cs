using Coupons.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Coupons.Application.Utils.Profiles;
using Coupons.Application.Services.Repositories;
using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuration of JWT
builder.Services.AddAuthentication(opt => {
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(configure => {
        configure.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "http://localhost:5044",
            ValidAudience = "http://localhost:5044",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("3C7A6C4E2754B9A31F225E201C02D82E")) 
        };
    });

//Configuration of the interfaces that will be used
builder.Services.AddScoped<ICustomers, CustomersRepository>();
builder.Services.AddScoped<ICoupons, CouponsRepository>();
builder.Services.AddScoped<ICouponHistory, CouponsHistoryRepository>();

//Configuration to connect at the database
builder.Services.AddDbContext<CouponsContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("Connection"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));

//Register AutoMapper profiles
builder.Services.AddAutoMapper(typeof(CouponsHistoryProfile), typeof(CouponsProfile), typeof(CustomerProfile));

//Configuration of controllers
builder.Services.AddControllers();

//Configuration to use the api with CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", builder =>
    {
        builder.AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin();
    });
});

//Configuration of JWT
builder.Services.AddAuthentication();

var app = builder.Build();

//Register the use of Cors
app.UseCors("AllowAnyOrigin");

//Register the use of JWT
app.UseAuthentication();
app.UseAuthorization();

//Mapping of controllers
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
