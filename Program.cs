using Coupons.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Coupons.Application.Utils.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
builder.Services.AddAuthentication("Bearer").AddJwtBearer();

var app = builder.Build();

//Mapping of controllers
app.MapControllers();

//Register the use of Cors
app.UseCors("AllowAnyOrigin");

//Register the use of JWT
app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
