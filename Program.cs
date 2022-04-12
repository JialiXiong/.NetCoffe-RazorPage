global using W21_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("DBContext");
var serverVersion = new MariaDbServerVersion(builder.Configuration.GetValue<string>("DBMSVersion"));
builder.Services.AddDbContext<DBContext>(options =>
    options.UseLazyLoadingProxies().UseMySql(connectionString, serverVersion));

builder.Services.AddDefaultIdentity<SiteUser>(options =>
options.SignIn.RequireConfirmedAccount = true)
.AddEntityFrameworkStores<DBContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
