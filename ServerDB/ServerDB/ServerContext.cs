using Microsoft.EntityFrameworkCore;
using ServerDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerDB
{
	public class ServerContext : DbContext
	{
		public DbSet<ServerModel> Servers { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
		{
			var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ServerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			dbContextOptions.UseSqlServer(cs);
		}
	}
}
