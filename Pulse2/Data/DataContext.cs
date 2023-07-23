using Pulse2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pulse2.Data
{
	public class DataContext : DbContext
	{
		public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
		public DbSet<Department> Departments { get; set; }

		// Add constructor to specify the connection string (modify it according to your local database)
		public DataContext() : base("name=PulseEntities")
		{
		}
	}
}