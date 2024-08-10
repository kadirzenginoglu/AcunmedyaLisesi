using AcunmedyaLisesi.Data;
using AcunmedyaLisesi.Repository.Shared.Abstract;
using AcunmedyaLisesi.Repository.Shared.Concrete;
using AcunmedyaUzmanlýk.Business.Shared.Abstract;
using AcunmedyaUzmanlýk.Business.Shared.Concrete;
using AcunmedyaUzmanlýk.Business.Shared.Service.Abstract;
using AcunmedyaUzmanlýk.Business.Shared.Service.Concrete;
using Microsoft.EntityFrameworkCore;
using YeniAcunmedyaLisesi.Models.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<IUserService, UserService>();
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

app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.Run();


