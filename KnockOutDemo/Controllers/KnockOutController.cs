﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockOutDemo.Controllers
{
    public class KnockOutController : Controller
    {
        //
        // GET: /KnockOut/
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult ContactsEditor()
		{
			return View();
		}		
	}
}