using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
	public class ContextBase(DbContextOptions<ContextBase> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Produto> Produto { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GetStringConectionConfig());
				base.OnConfiguring(optionsBuilder);
			}
		}

		private string GetStringConectionConfig()
		{
			string strCon = "Data Source=DESKTOP-FRAN\\SQLEXPRESS;Initial Catalog=DDD_ECOMMERCE;Integrated Security=True;TrustServerCertificate=True";
			return strCon;
		}


	}
}

