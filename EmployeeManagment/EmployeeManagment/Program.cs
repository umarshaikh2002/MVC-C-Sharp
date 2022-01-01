using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagment.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EmployeeManagmentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeManagmentContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Views/Shared/Error.cshtml");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
