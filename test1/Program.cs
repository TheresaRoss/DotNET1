using Microsoft.EntityFrameworkCore;
using test1.Models.db;

var builder = WebApplication.CreateBuilder(args);
//Add database 
builder.Services.AddDbContext<DemoShopContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DemoShoDB")));

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); //make Index method in controller name home do first, with param id which is optional

app.Run();

