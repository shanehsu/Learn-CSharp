﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Intro.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return Json("你好！");
        }
        // name 以及 friend 是 Query Parameter
        // 你也可以為他們提供 default
        public IActionResult Welcome(String name, String friend)
        {
            if (name == null) {
                return NotFound();
            }
            return Json($"{name}，你好！" + ((friend == null) ? "你沒有朋友。" : $"你的朋友是{friend}。"));
        }
    }
}