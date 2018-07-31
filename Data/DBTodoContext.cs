using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.Models;

namespace Data
{
	public class DBTodoContext : DbContext, IDBTodoContext
	{
		static DBTodoContext()
		{
			Database.SetInitializer<DbContext>(null);
		}

		public DBTodoContext() :base("TodoDbContext")
		{

		}

		public DbSet<Todo> Todos { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new TodoConfiguration());
		}

	}
}
