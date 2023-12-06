using Microsoft.OpenApi.Models;
using WebCinema.Repository;
using WebCinema.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebCinema.Entities;
using WebCinema.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<web_cinema3Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDb"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<GheServices>();
builder.Services.AddScoped<PhongServices>();
builder.Services.AddScoped<CtdatveService>();
builder.Services.AddScoped<TdKhachHangServices>();
builder.Services.AddScoped<TheLoaiServices>();
builder.Services.AddScoped<LichChieuPhimServices>();
builder.Services.AddScoped<TtDatVeServices>();
builder.Services.AddScoped<TrangThaiGheServices>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(MyRepository<>));


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
