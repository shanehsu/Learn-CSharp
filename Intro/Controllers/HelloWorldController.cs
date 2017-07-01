using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Intro.Controllers {
    public class HelloWorldController : Controller {
        public IActionResult Index(Int64 repeat = 5) {
            ViewData["repeat"] = repeat;
            return View();
        }
        // name 以及 friend 是 Query Parameter
        // 你也可以為他們提供 default
        public IActionResult Welcome(String name, String friend) {
            if (name == null) {
                return NotFound();
            }
            return Json($"{name}，你好！" + ((friend == null) ? "你沒有朋友。" : $"你的朋友是{friend}。"));
        }
    }

    public static class ExtensionMethods {
        public static String Repeated(this String value, Int64 times) {
            var result = "";
            while (times -- != 0) {
                result += value;
            }
            return result;
        }
    }
}