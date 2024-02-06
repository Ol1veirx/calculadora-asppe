using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASPPE___SOMA.Data;
using System.Globalization;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ASPPE___SOMAContext>(options =>
options.UseMySql(builder.Configuration.GetConnectionString("ASPPE___SOMAContext"), new MySqlServerVersion(new Version(8, 0, 26))));
// Add services to the container.
builder.Services.AddControllersWithViews();
var cultureInfo = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

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


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
