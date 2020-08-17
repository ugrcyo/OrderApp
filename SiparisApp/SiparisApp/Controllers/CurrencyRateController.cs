using SiparisApp.Controllers.OOP_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiparisApp.Models;

namespace SiparisApp.Controllers
{
	public class CurrencyRateController : Controller, ICurrencyRate
	{
		SiparisDBEntities db = new SiparisDBEntities();

		public ActionResult CreateCurrencyRate()
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
		public ActionResult CreateCurrencyRate(CurrencyRate currencyrate)
		{
			db.CurrencyRate.Add(currencyrate);
			db.SaveChanges();
			return RedirectToAction("CurrencyRateList", "CurrencyRate");
		}

		public ActionResult CurrencyRateList()
		{
			return View(db.CurrencyRate.ToList());
		}

		[HttpPost]
		public bool DeleteCurrencyRate(int ID)
		{
			try
			{
				CurrencyRate currencyRate = db.CurrencyRate.Where(s => s.ID == ID).First();
				db.CurrencyRate.Remove(currencyRate);
				db.SaveChanges();
				return true;
			}
			catch (System.Exception)
			{
				return false;
			}
		}

		[HttpPost]
		public ActionResult UpdateCurrencyRate(CurrencyRate currencyrate)
		{
			var update = db.CurrencyRate.FirstOrDefault(k => k.ID == currencyrate.ID);
			db.Entry(update).CurrentValues.SetValues(currencyrate);
			if (db.SaveChanges() > 0)
			{
				return RedirectToAction("CurrencyRateList", "CurrencyRate");
			}
			return View("Güncelleme başarısız");
		}

		public ActionResult UpdateCurrencyRate(int ID)
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