using SiparisApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SiparisApp.Controllers.OOP_Class
{
	interface IOrder
	{
		ActionResult CreateOrder();

		ActionResult CreateOrder(Order order);

		bool DeleteOrder(int ID);

		ActionResult OrderList();
	}
}
