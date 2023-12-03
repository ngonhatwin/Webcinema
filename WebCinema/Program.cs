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

// Đăng ký ICtdatveRepository và CtdatveRepository
//builder.Services.AddScoped<IRepository<CtdatveModels>, CtdatveRepository>();
//// Đăng ký ICtdatveService và CtdatveService
//builder.Services.AddScoped<ICtdatveService, CtdatveService>();
//builder.Services.AddScoped<IRepository<TtdatveModels>, TtDatVeRepository>();
//builder.Services.AddScoped<ITtDatVeServices,TtDatVeServices>();6
builder.Services.AddScoped<IRepository<LichchieuphimModels>, LichChieuPhimRepository>();
builder.Services.AddScoped<ILichChieuPhimServices, LichChieuPhimServices>();
builder.Services.AddScoped<IRepository<PhongModels>, PhongRepository>();
builder.Services.AddScoped<IPhongServices, PhongServices>();
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
