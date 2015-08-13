using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yoseMVC.Controllers
{
    public class MinesweeperController : Controller
    {
        //
        // GET: /Minesweeper/

        public ActionResult Index()
        {
            return View();
        }

    }
}
