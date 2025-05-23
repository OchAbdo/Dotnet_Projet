using Microsoft.EntityFrameworkCore;
using Projet.Models;
using Projet.Repositories.Repositories;
using Projet.Repositories.RepositoriesContracts;
using Projet.Services.Services;
using Projet.Services.ServicesContracts;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Activer le service relatif au DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationdbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ApplicationdbContext>();

builder.Services.AddScoped(typeof(GenericRepositoryC<>), typeof(GenericRepository<>));
builder.Services.AddScoped<UnitOfWorkC , UnitOfWork>();
builder.Services.AddScoped<UtilisateurServiceC, UtilisateurService>();
builder.Services.AddScoped<ProjetServiceC, ProjetService>();
builder.Services.AddScoped<AffectationServiceC, AffectationService>();
builder.Services.AddScoped<RapportServiceC, RapportService>();
builder.Services.AddScoped<TacheServiceC, TacheService>();

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

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
