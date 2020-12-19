using Project_Tech_News.DAO;
using Project_Tech_News.Models.FW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Tech_News.Controllers
{
    public class HomeController : Controller
    {
        News_TechEntities db = new News_TechEntities();
        public ActionResult Index()
        {
            return View();
        }
       
        [ChildActionOnly]//chi duoc nhung , khong duoc goi.
        public ActionResult Footer()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult Header()
        {
            var list_danhmucmenu = db.Danh_muc.Where(x => x.Status == 1).ToList();
            return PartialView(list_danhmucmenu);
        }

        [ChildActionOnly]
        public ActionResult Header_mobile()
        {
            var list_danhmucmenu = db.Danh_muc.Where(x => x.Status == 1).ToList();
            return PartialView(list_danhmucmenu);
        }
    }
}