﻿using MersinLiman.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
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

// ⭐ Statik dosyaları (HTML, CSS, JS) sunmak için:
app.UseDefaultFiles(); // index.html gibi dosyaları otomatik sunar
app.UseStaticFiles();  // wwwroot altındaki dosyaları sunar

app.MapControllers();

app.Run();
