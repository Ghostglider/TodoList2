using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
	public class Todo
	{
		public int Id { get; set; }

		public string TodoLable { get; set; }

		public string TodoDescription { get; set; }

		public bool Traite { get; set; }
	}
}
