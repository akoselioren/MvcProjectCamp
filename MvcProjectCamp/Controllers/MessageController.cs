using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager cm = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            var messageInList=cm.GetListInbox();
            return View(messageInList);
        }
        public ActionResult Sendbox()
        {
            var messageSendList = cm.GetListSendBox();
            return View(messageSendList);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            return View();
        }
    }
}