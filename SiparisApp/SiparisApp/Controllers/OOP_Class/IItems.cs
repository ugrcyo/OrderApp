using SiparisApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SiparisApp.Controllers.OOP_Class
{
	interface IItems
	{
		ActionResult CreateItem();

		ActionResult CreateItem(Items item);

		ActionResult UpdateItem(int ID);

		ActionResult UpdateItem(Items item);

		bool DeleteItem(int ID);

		ActionResult ItemList();
	}
}
