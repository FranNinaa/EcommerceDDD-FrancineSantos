using AplicationApp.Interfaces;
using ApplicationApp.OpenApp;
using Domain.Interfaces.Generics;
using Domain.Interfaces.InterfaceProducto;
using Domain.Interfaces.InterfaceServices;
using Domain.Services;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Infrastructure.Repository.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebEcommerce.Data;

namespace WebEcommerce
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var SqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
			builder.Services.AddDbContext<ContextBase>(options =>
				options.UseSqlServer(SqlConnection)); // This line configures your DbContext

			builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<ContextBase>();

			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();

			//interface e repositorio
			//ele gerenciaq o repositorio e a interface e injeta
			builder.Services.AddSingleton(typeof(IGenerics<>), typeof(RepositoryGenerics<>));
			builder.Services.AddSingleton<IProducto, RepositoryProduto>();

			//interface aplicação
			builder.Services.AddSingleton<InterfaceProductoApp, AppProduct>();

			//servico dominio
			builder.Services.AddSingleton<IServiceProducto, ServiceProducto>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
			}
			else
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
			app.MapRazorPages();

			app.Run();
		}
	}
}
