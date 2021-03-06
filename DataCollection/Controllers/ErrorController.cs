﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataCollection.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /Error/
        public ActionResult Index()
        {
            Response.StatusCode = 500;
            return View("Error");
        }

        //
        // GET: /Error/PageNotFound
        public ActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }

        public ActionResult Unauthorized()
        {
            return View();
        }
	}
}