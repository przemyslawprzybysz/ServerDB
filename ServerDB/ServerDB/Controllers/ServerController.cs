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
			var serverList = serverManager.GetServers();
			return View(serverList);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(ServerModel serverModel)
		{
			serverManager.AddServer(serverModel);
			TempData["AlertMsg"] = "New server added successfully!";
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Remove(int id)
		{
			var server = serverManager.GetServer(id);
			return View(server);
		}

		[HttpPost]
		public IActionResult RemoveConfirm(int id)
		{
			serverManager.RemoveServer(id);
			TempData["AlertMsg"] = "Server removed successfully!";
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var server = serverManager.GetServer(id);
			return View(server);
		}

		[HttpPost]
		public IActionResult Edit(ServerModel server)
		{
			serverManager.UpdateServer(server);
			TempData["AlertMsg"] = "Server updated successfully!";
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Details(int id)
		{
			var server = serverManager.GetServer(id);
			return View(server);
		}
	}
}
