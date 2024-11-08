var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// add connection string
builder.Services.AddDbContext<BasicDBContext>(options => options.useSqlite(builder.configuration.GetConnectionString("BasicMVCContextString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.useHsts();

}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
