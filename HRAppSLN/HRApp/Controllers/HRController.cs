﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRApp.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        public ActionResult Index()
        {
            return View();
        }
    }
}