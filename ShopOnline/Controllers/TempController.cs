using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopOnline.Models;


namespace ShopOnline.Controllers
{
    public class TempController : Controller
    {
        WebBanhangEntities2 _db = new WebBanhangEntities2();
        // GET: TempShopOnlineEntities1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getMenu()
        {
            var v = from t in _db.menus
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }

    }

}