using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Models;

namespace Data.Mapping
{
	public class MappingTodo : IMappingTodo
	{
		public Todo MappingTodoLightToTodo(TodoLight todoLight)
		{
			Todo _todo = new Todo();

			_todo.TodoLable = todoLight.TodoLabel;
			_todo.TodoDescription = todoLight.TodoDescription;
			_todo.Traite = false;

			return _todo;
		}
	}
}
