using SiparisApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SiparisApp.Controllers.OOP_Class
{
	interface IOrderDetails
	{
		ActionResult CreateOrderDetails();

		ActionResult CreateOrderDetails(OrderDetails orderdetails);

		ActionResult OrderDetailsList();

		ActionResult OrderDetails(int ID);
	}
}
