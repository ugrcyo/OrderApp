using SiparisApp.Controllers.OOP_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiparisApp.Models;

namespace SiparisApp.Controllers
{
	public class CurrencyController : Controller, ICurrency
	{
		SiparisDBEntities db = new SiparisDBEntities();

		public ActionResult CreateCurrency()
		{
			return View();
		}

		[HttpPost]
		public ActionResult CreateCurrency(Currency currency)
		{
			db.Currency.Add(currency);
			db.SaveChanges();
			return RedirectToAction("CurrencyList","Currency");
		}

		public ActionResult CurrencyList()
		{
			return View(db.Currency.ToList());
		}

		[HttpPost]
		public bool DeleteCurrency(int Code)
		{
			try
			{
				Currency currency = db.Currency.Where(s => s.Code == Code).First();
				db.Currency.Remove(currency);
				db.SaveChanges();
				return true;
			}
			catch (System.Exception)
			{
				return false;
			}
		}

		[HttpPost]
		public ActionResult UpdateCurrency(Currency currency)
		{
			var update = db.Currency.FirstOrDefault(k => k.Code == currency.Code);
			db.Entry(update).CurrentValues.SetValues(currency);
			if (db.SaveChanges() > 0)
			{
				return RedirectToAction("CurrencyList","Currency");
			}
			return View("Güncelleme başarısız");
		}

		public ActionResult UpdateCurrency(int Code)
		{
			var selected = db.Currency.Where(k => k.Code == Code).First();
			return View(selected);
		}
	}
}