using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Libary.DataAccess.Concrete
{
	public class Context : DbContext
	{
		public Context() : base("Data Source=BamGumToshiba;Initial Catalog=VtysProjeDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
		{
		}

		public DbSet<Kullanici> Kullanicilar { get; set; }
		public DbSet<Sarki> Sarkilar { get; set; }
		public DbSet<SatilanSarki> SatilanSarkilar { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Kullanici>().ToTable("Kullanicilar");
			modelBuilder.Entity<Sarki>().ToTable("Sarkilar");
			modelBuilder.Entity<SatilanSarki>().ToTable("SatilanSarkilar");
			modelBuilder.Entity<SatilanSarki>().HasKey(ss => new { ss.SarkiID, ss.KullaniciID });
		}
	}
}
