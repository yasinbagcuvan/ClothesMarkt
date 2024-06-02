using ClothesMarkt.BLL.Managers.Concrete;
using ClothesMarkt.DAL.Context;
using ClothesMarkt.DAL.Repositories.Concrete;
using ClothesMarkt.DAL.Services.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(x => x.AddDefaultPolicy(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ClothesMarktDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("ClothesConStr"));
}, ServiceLifetime.Scoped);

builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ClothesMarktDbContext>();

builder.Services.AddAutoMapper(typeof(Assembly));

builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<CategoryManager>();

builder.Services.AddScoped<TshirtRepo>();
builder.Services.AddScoped<TshirtService>();
builder.Services.AddScoped<TshirtManager>();

builder.Services.AddScoped<ShirtRepo>();
builder.Services.AddScoped<ShirtService>();
builder.Services.AddScoped<ShirtManager>();

builder.Services.AddScoped<RenkRepo>();
builder.Services.AddScoped<RenkService>();
builder.Services.AddScoped<RenkManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
