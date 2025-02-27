using BookMyHome.Shared.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BookMyHomeWebApp.Persistence.ContextDB
{
	public class MyDbContext : DbContext
	{
		private readonly IConfiguration _configuration;

		public MyDbContext()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true); // Local overrides

			_configuration = builder.Build();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = _configuration.GetConnectionString("DefaultConnection");
			optionsBuilder.UseSqlServer(connectionString);
		}


		public DbSet<Bolig> BoligEF { get; set; }
		public DbSet<Bruger> BrugerEF { get; set; }
		public DbSet<Adresse> AresseEF { get; set; }
		public DbSet<Anmeldelse> AnmeldelseEF { get; set; }
		public DbSet<Booking> BookingEF { get; set; }
		public DbSet<PostnummerOgBy> postnummerOgByEF { get; set; }

	}
}
