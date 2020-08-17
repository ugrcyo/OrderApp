using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using SiparisApp.Models;

namespace SiparisApp.Controllers.OOP_Class
{
	interface ICurrency
	{
		ActionResult CreateCurrency();

		ActionResult CreateCurrency(Currency currency);

		ActionResult UpdateCurrency(int Code);

		ActionResult UpdateCurrency(Currency currency);

		bool DeleteCurrency(int Code);

		ActionResult CurrencyList();
	}
}
