using Data.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public interface ITodoRepository
	{
		IEnumerable<Todo> GetAllTodo();

		Todo GetTodoById(int TodoId);

		void CreateTodo(TodoLight todoLight);

		void UpdateTodo(int TodoId, TodoLight todoLight);

		void DeleteTodo(int TodoId);
	}
}
