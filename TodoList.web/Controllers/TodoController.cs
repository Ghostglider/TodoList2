using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;
using Data.Models;
using Data.Repositories;
using Models;
using TodoList.web.Services;

namespace TodoList.web.Controllers
{
	[RoutePrefix("api/Todo")]
	public class TodoController : ApiController
	{
		private readonly ITodoRepository _todoRepository;

		public TodoController(ITodoRepository todorepository, IDBTodoContext context)
		{
			if (todorepository == null) throw new ArgumentNullException(nameof(todorepository));
			_todoRepository = todorepository;
		}
		// GET
		[HttpGet]
		[Route("ViewAll")]
		public IHttpActionResult Get()
		{
			return Ok();
		}

		// GET: api/Todo/5
		[HttpGet]
		[Route("ViewTodo /{TodoId:int}")]
        public IHttpActionResult Get(int TodoId)
        {
			return Ok();
        }

        // POST: api/Todo
		[HttpPost]
		[PerformAction]
		[Route("AddTodo")]
        public IHttpActionResult AddTodo([FromBody]TodoLight todoLight)
        {
			_todoRepository.CreateTodo(todoLight);
			
			return Ok();
        }

        // PUT: api/Todo/5
		[HttpPut]
		[Route("ModifTodo/{IdTodo:int}")]
        public void Put(int IdTodo, [FromBody]string value)
        {
        }

        // DELETE: api/Todo/5
		[HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
