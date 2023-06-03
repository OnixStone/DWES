using Microsoft.EntityFrameworkCore;
using ExamenFinalDWES.Repository;
using ExamenFinalDWES.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AmazonMontecasteloRepository>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("ConexionExamenFinal");
    return new AmazonMontecasteloRepository(connectionString);
});

builder.Services.AddDbContext<AmazonMontecasteloContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionExamenFinal")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    name: "Login",
    pattern: "Login/Logueate",
    defaults: new { controller = "Login", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Login", action = "Index" });

app.Run();
