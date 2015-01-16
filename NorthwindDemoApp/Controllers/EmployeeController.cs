using System;
using System.Web.Mvc;

namespace NorthwindDemoApp.Controllers
{
	/// <summary>
	/// Description of Employee.
	/// </summary>
	public class EmployeeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Details(int id)
		{
			return View();
		}
		
		public ActionResult Create()
		{
			return View();
		}
		
		[HttpPost]
		public ActionResult Create(FormCollection values)
		{
			return View();
		}
		
		public ActionResult Edit(int id)
		{
			return View();
		}
		
		[HttpPost]
		public ActionResult Edit(int id, FormCollection values)
		{
			return View();
		}
		
		public ActionResult Delete(int id)
		{
			return View();
		}
	}
}