using BusinessLayer.Concete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            messageManager.TAdd(p);

            return Redirect("/Default/Index");
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
            //}

            //[HttpGet]
            //public PartialViewResult SendMessage()
            //{
            //    return PartialView();
            //}

            //[HttpPost]
            //public PartialViewResult SendMessage(Message p)
            //{
            //    MessageManager messageManager = new MessageManager(new EfMessageDal());
            //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //    p.Status = true;
            //    messageManager.TAdd(p);
            //    return PartialView();
            //}
        }
    }
}
