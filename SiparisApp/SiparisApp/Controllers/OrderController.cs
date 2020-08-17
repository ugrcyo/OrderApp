using SiparisApp.Controllers.OOP_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiparisApp.Models;


namespace SiparisApp.Controllers
{
	public class OrderController : Controller, IOrder
	{
		SiparisDBEntities db = new SiparisDBEntities();

		[HttpPost]
		public ActionResult CreateOrder(Order order)
		{
			db.Order.Add(order);
			db.SaveChanges();
			return RedirectToAction("OrderList", "Order");
		}

		public ActionResult CreateOrder()
		{
			return View();
		}

		[HttpPost]
		public bool DeleteOrder(int ID)
		{
			try
			{
				Order order = db.Order.Where(s => s.ID == ID).First();
				db.Order.Remove(order);
				db.SaveChanges();
				return true;
			}
			catch (System.Exception)
			{
				return false;
			}
		}

		public ActionResult OrderList()
		{
			return View(db.Order.ToList());
		}
	}
}