using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleInjector;
using System.Web.Http;
using Data;
using Data.Repositories;
using Data.Mapping;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;

namespace TodoList.web
{
	public static class SimpleInjectorConfig
	{
		public static Container UseContainer(HttpConfiguration configuration)
		{
			var container = new Container();

			container.Options.DefaultLifestyle = Lifestyle.Scoped;
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Options.AllowOverridingRegistrations = true;

			//context
			container.Register<IDBTodoContext, DBTodoContext>();

			//repository
			container.Register<ITodoRepository, TodoRepository>();

			//mapping
			container.Register<IMappingTodo, MappingTodo>();

			container.Verify();

			configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
			return container;
		}
	}
}