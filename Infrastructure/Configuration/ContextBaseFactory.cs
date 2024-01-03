using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
	public class ContextBaseFactory : IDesignTimeDbContextFactory<ContextBase>
	{
		public ContextBase CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<ContextBase>();

			// Substitua pela sua string de conexão. Você pode movê-la para um local seguro ou variável de ambiente.
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-FRAN\\SQLEXPRESS;Initial Catalog=DDD_ECOMMERCE;Integrated Security=True;TrustServerCertificate=True");

			return new ContextBase(optionsBuilder.Options);
		}
	}
}
