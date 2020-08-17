using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using SiparisApp.Models;

namespace SiparisApp.Controllers.OOP_Class
{
	interface ICurrencyRate
	{
		ActionResult CreateCurrencyRate();

		ActionResult CreateCurrencyRate(CurrencyRate currencyrate);

		ActionResult UpdateCurrencyRate(int ID);

		ActionResult UpdateCurrencyRate(CurrencyRate currencyrate);

		bool DeleteCurrencyRate(int ID);

		ActionResult CurrencyRateList();
	}
}
