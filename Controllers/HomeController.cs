using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  WebApplicationshop.reported;
using WebApplicationshop.Models;

namespace WebApplicationshop.Controllers
{
    public class HomeController : Controller
    {

        private onlineshopingEntities3 objonlineshopingEntities3;
        public HomeController()
        {
            objonlineshopingEntities3 = new onlineshopingEntities3();
        }
        // GET: Home
        public ActionResult Index()
        {
            customerrepositorycs objcustomerrepositorycs = new customerrepositorycs();
            itemrepository objitemrepository = new itemrepository();
            paymenttyperepository objpaymenttyperepository = new paymenttyperepository();
            var objMultiplrModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
          (objcustomerrepositorycs.GetAllcustomers(), objitemrepository.GetAllitems(), objpaymenttyperepository.GetAllpaymenttypes());

            return View(objMultiplrModels);
        }
     [HttpGet]
        public JsonResult getitemsprice(int itemid)
        {

            decimal price = objonlineshopingEntities3.items.Single(model => model.itemid == itemid).itemprice;
            return Json(price, JsonRequestBehavior.AllowGet);
        }
    }
        
}
