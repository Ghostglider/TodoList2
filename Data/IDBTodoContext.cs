using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.Models;

namespace Data
{
	public interface IDBTodoContext
	{
		Database Database{ get;}

		DbSet<Todo> Todos { get; set; }

	}
}
