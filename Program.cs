using Microsoft.EntityFrameworkCore;
using BasicMVC.DataLayer;
using BasicMVC.Models; 
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Identity services with roles (optional)
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<AuthDBContext>()
  .AddDefaultTokenProviders();

// Add connection string
builder.Services.AddDbContext<AuthDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("AuthDBContextString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Ensures authentication is handled
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
