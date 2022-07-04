using BusinessLayer.Concete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Default
{
    public class _Contact : ViewComponent
    {
        //ContactManager contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            //var values = contactManager.TGetList();
            return View(/*values*/);
        }
    }
}
