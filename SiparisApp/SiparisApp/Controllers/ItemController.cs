using SiparisApp.Controllers.OOP_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiparisApp.Models;

namespace SiparisApp.Controllers
{
	public class ItemController : Controller, IItems
	{
		SiparisDBEntities db = new SiparisDBEntities();

		public ActionResult CreateItem()
		{
			List<SelectListItem> sanalList = new List<SelectListItem>();
			foreach (var item in db.Currency.ToList())
			{
				sanalList.Add(new SelectListItem
				{
					Text = item.Name.ToString(),
					Value = item.Code.ToString()
				});
			}
			ViewBag.CurrencyCode = sanalList;
			return View();
		}

		[HttpPost]
		public ActionResult CreateItem(Items item)
		{
			db.Items.Add(item);
			db.SaveChanges();
			return RedirectToAction("ItemList","Item");
		}

		[HttpPost]
		public bool DeleteItem(int ID)
		{
			try
			{
				Items items = db.Items.Where(s => s.ID == ID).First();
				db.Items.Remove(items);
				db.SaveChanges();
				return true;
			}
			catch (System.Exception)
			{
				return false;
			}
		}

		public ActionResult ItemList()
		{
			return View(db.Items.ToList());
		}

		[HttpPost]
		public ActionResult UpdateItem(Items item)
		{
			var update = db.Items.FirstOrDefault(k => k.ID == item.ID);
			db.Entry(update).CurrentValues.SetValues(item);
			if (db.SaveChanges() > 0)
			{
				return RedirectToAction("ItemList", "Item");
			}
			return View("Güncelleme başarısız");
		}

		public ActionResult UpdateItem(int ID)
		{
			var selected = db.Items.Where(k => k.ID == ID).First();
			List<SelectListItem> sanalList = new List<SelectListItem>();
			foreach (var item in db.Currency.ToList())
			{
				sanalList.Add(new SelectListItem
				{
					Text = item.Name.ToString(),
					Value = item.Code.ToString()
				});
			}
			ViewBag.CurrencyCode = sanalList;
			return View(selected);
		}
	}
}