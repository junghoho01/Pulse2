using Pulse2.Data;
using Pulse2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Pulse2.Controllers
{
	[System.Web.Http.RoutePrefix("api/employees")]
	public class EmployeesController : ApiController
	{
		private DataContext db = new DataContext();

		// GET: api/employees
		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("")]
		public IHttpActionResult GetEmployees()
		{
			var youngest = db.EmployeeProfiles.OrderBy(e => e.Age).FirstOrDefault();
			var eldest = db.EmployeeProfiles.OrderByDescending(e => e.Age).FirstOrDefault();

			return Ok(new List<EmployeeProfile> { youngest, eldest });
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}