using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManeger hm = new HeadingManeger(new EfHeadingDal());
        ContentManager cm=new ContentManager(new EfContentDal());
        public ActionResult Headings()
        {
            var headinglist=hm.GetList();
            return View(headinglist);
        }
        public PartialViewResult Index(int id=1)
        {
            var contentlist=cm.GetListByHeadingID(id);
            return PartialView(contentlist);
        }
    }
}