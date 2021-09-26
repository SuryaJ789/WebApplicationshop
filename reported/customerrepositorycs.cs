using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationshop.Models;

namespace WebApplicationshop.reported
{
    public class customerrepositorycs
    {
        private onlineshopingEntities3 objonlineshopingEntities3;
        public customerrepositorycs()
        {
            objonlineshopingEntities3 = new onlineshopingEntities3();
        }

        public IEnumerable<SelectListItem> GetAllcustomers()
        {
            IEnumerable<SelectListItem> objselectListitems = new List<SelectListItem>();
            objselectListitems = (from obj in objonlineshopingEntities3.customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.customername,
                                      Value = obj.customerid.ToString(),
                                      Selected = true

                                  }).ToList();
            return objselectListitems;
        }
    }

}
