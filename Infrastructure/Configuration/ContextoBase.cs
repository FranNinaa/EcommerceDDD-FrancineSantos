using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
	public class ContextBase : IdentityDbContext<ApplicationUser>
	{
		public ContextBase(DbContextOptions<ContextBase> options) : base(options)
		{
		}

		public DbSet<Produto> Produto { get; set; }
		public DbSet<CompraUsuario> CompraUsuario { get; set; }

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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Configurações para a entidade CompraUsuario
			modelBuilder.Entity<CompraUsuario>(entity =>
			{
				entity.ToTable("TB_COMPRA_USUARIO");

				// Definição das colunas com a ordem especificada
				entity.Property(e => e.Id).HasColumnName("CUS_ID");
				entity.Property(e => e.IdProduto).HasColumnName("ProdutoId").HasColumnOrder(1);
				entity.Property(e => e.UserId).HasColumnName("UserId").HasColumnOrder(2);
				entity.Property(e => e.Estado).HasColumnName("CUS_ESTADO");
				entity.Property(e => e.QtdCompra).HasColumnName("CSU_QTD");

				// Relações e comportamento de exclusão
				entity.HasOne(d => d.ApplicationUser)
					.WithMany()
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.NoAction);

				entity.HasOne(d => d.Produto)
					.WithMany()
					.HasForeignKey(d => d.IdProduto)
					.OnDelete(DeleteBehavior.NoAction);
			});

			// Configurações para a entidade Produto
			modelBuilder.Entity<Produto>(entity =>
			{
				entity.ToTable("Produtos");
				entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
			});
		}
	}
}
