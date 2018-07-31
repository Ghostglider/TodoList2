using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TodoList.web.Services
{
	public class PerformAction : ActionFilterAttribute
	{
		public override void OnActionExecuting(HttpActionContext actionContext)
		{
			Debug.WriteLine("Demarrge de l'executon : " + DateTime.Now, "PerformeAction");
			//base.OnActionExecuting(actionContext);
		}

		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			Debug.WriteLine("Après l'execution l'executon : " + DateTime.Now, "PerformeAction");
			//base.OnActionExecuted(actionExecutedContext);
		}
	}
}