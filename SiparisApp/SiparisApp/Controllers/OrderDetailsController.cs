using SiparisApp.Controllers.OOP_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiparisApp.Models;

namespace SiparisApp.Controllers
{
    public class OrderDetailsController : Controller,IOrderDetails
    {
		SiparisDBEntities db = new SiparisDBEntities();

		public ActionResult CreateOrderDetails()
		{			
			List<SelectListItem> sanalList = new List<SelectListItem>();
			foreach (var item in db.Currency.ToList())
			{
				sanalList.Add(new SelectListItem
				{
					Text = item.Name,
					Value = item.Code.ToString()
				});
			}
			ViewBag.CurrencyCode = sanalList;

			List<SelectListItem> sanalList1 = new List<SelectListItem>();
			foreach (var item in db.Items.ToList())
			{
				sanalList1.Add(new SelectListItem
				{
					Text = item.ItemName,
					Value = item.ID.ToString()
				});
			}
			ViewBag.ItemID = sanalList1;			
			List<SelectListItem> sanalList2 = new List<SelectListItem>();
			foreach (var item in db.Items.ToList())
			{
				sanalList2.Add(new SelectListItem
				{
					Text = item.UnitPrice.ToString(),
					Value = item.ID.ToString()
				});
			}
			ViewBag.UnitPriceID = sanalList2;
			return View();
		}

		[HttpPost]
		public ActionResult CreateOrderDetails(OrderDetails orderdetails)
		{
			db.OrderDetails.Add(orderdetails);
			db.SaveChanges();
			return RedirectToAction("OrderList", "Order");
		}

		public ActionResult OrderDetails(int ID)
		{
			var detail = db.OrderDetails.ToList().FirstOrDefault(k => k.ID == ID);

			return View(detail);
		}

		public ActionResult OrderDetailsList()
		{
			return View(db.OrderDetails.ToList());
		}
	}
}