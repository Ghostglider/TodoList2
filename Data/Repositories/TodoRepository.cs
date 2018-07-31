using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Models;
using Data.Mapping;
using System.Data.Entity.ModelConfiguration;

namespace Data.Repositories
{
	public class TodoRepository : ITodoRepository
	{
		private readonly IDBTodoContext _dbTodoContext;
		private readonly IMappingTodo _mappingTodo;

		/// <summary>
		/// Constructor
		/// </summary>
		public TodoRepository(IDBTodoContext context, IMappingTodo mappingTodo)
		{
			if (mappingTodo == null) throw new ArgumentNullException(nameof(mappingTodo));

			_dbTodoContext = context;
			_mappingTodo = mappingTodo;
		}
		public void CreateTodo(TodoLight todoLight)
		{
			var fullTodo = _mappingTodo.MappingTodoLightToTodo(todoLight);

			_dbTodoContext.Todos.Add(fullTodo);

			return;
			
		}

		public void DeleteTodo(int TodoId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Todo> GetAllTodo()
		{
			return _dbTodoContext.Todos.AsEnumerable<Todo>().ToArray();
		}

		public Todo GetTodoById(int TodoId)
		{
			throw new NotImplementedException();
		}

		public void UpdateTodo(int TodoId, TodoLight todoLight)
		{
			throw new NotImplementedException();
		}
	}
}
