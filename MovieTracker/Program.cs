

using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// var connectionString = "server=localhost!;user=movietracker;password=movietracker;database=movietracker";
// var serverVersion = new MySqlServerVersion(new Version(8, 0, 37));

// builder.Services.AddDbContext<MovieTrackerDbContext>(dbContextOptions => 
//     dbContextOptions.UseMySql(connectionString, serverVersion));

// builder.Services.AddIdentity<User, IdentityRole>(
//     options => 
//     {
//         options.SignIn.RequireConfirmedAccount = false;
//         options.Password.RequireNonAlphanumeric = false;
//     })
//     .AddRoles<IdentityRole>()
//     .AddEntityFrameworkStores<MovieTrackerDbContext>().AddDefaultTokenProviders().AddDefaultUI();

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

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});




app.MapRazorPages();

app.Run();
