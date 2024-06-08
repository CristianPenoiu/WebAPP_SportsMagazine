using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;
using WebApplication1.Repositories;
using WebApplication1.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Authentication.Google;
//using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
builder.Services.AddScoped<IContactInfo, ContactInfoService>();
builder.Services.AddScoped<IRecenziiRepository, RecenziiRepository>();
builder.Services.AddScoped<IRecenzii, RecenzieService>();
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
builder.Services.AddScoped<LoginService>();
builder.Services.AddScoped<RegisterService>();
builder.Services.AddDbContext<WebSportsAppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebSportsAppDbContext")));

builder.Services.AddDefaultIdentity<IdentityUser>().AddDefaultTokenProviders().AddRoles<IdentityRole>().AddEntityFrameworkStores<WebSportsAppDbContext>();
//builder.Services.AddAuthentication(options =>
//{
  //  options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    //options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;

//})
  //.AddCookie()
  //.AddGoogle(GoogleDefaults.AuthenticationScheme, options =>
  //{
    //  options.ClientId = builder.Configuration.GetSection("GoogleKeys:ClientId").Value;
     // options.ClientSecret = builder.Configuration.GetSection("GoogleKeys:ClientSecret").Value;
  //});
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
app.MapRazorPages();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
