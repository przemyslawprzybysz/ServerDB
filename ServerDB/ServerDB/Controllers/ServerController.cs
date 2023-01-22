using Microsoft.AspNetCore.Mvc;
using ServerDB.Logic;
using ServerDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerDB.Controllers
{
	public class ServerController : Controller
	{
		ServerManager serverManager = new ServerManager();
		public IActionResult Index()
		{
			var random = new Random();
			var server = new ServerModel()
			{
				Name = $"Test{random.Next(1, 100)}",
				OS = "Debian 11",
				IPAddress = $"10.0.0.{random.Next(1, 254)}",
				Location = "Warszawa ul. Serwerowa 12",
				MainAdmin = "Adam Nowak",
				Description = "Serwer testowy"
			};
			serverManager.AddServer(server);
			return View();
		}
	}
}
