﻿using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvc.Controllers
{
	public class Product : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
