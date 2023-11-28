using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NaomiRetroCloset.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddSession();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<NaomiRetroClosetContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("NaomiRetroClosetContext") ?? throw new InvalidOperationException("Connection string 'NaomiRetroClosetContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

