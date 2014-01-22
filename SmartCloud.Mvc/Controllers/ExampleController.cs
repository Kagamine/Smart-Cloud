using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartCloud.Mvc.Controllers
{
    public class ExampleController : Controller
    {
        // URL 是 /Example/Foo?bar=22334
        // 前面Example是由于这个类名叫ExampleController
        // 后面Foo是由于这个方法叫Foo
        public ActionResult Foo(int bar)
        {
            // 设置给ViewBag的属性，可以在cshtml中访问到
            ViewBag.Bar = bar;
            ViewBag.BarPlusOne = bar + 1;
            // View没有参数，所以调用的视图名（cshtml文件名）和方法名一致。
            return View();
        }

    }
}
