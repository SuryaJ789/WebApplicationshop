using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationshop.Models;
using System.Web.Mvc;
namespace WebApplicationshop.reported
{
    public class itemrepository
    {
        private onlineshopingEntities3 objonlineshopingEntities3;

        public itemrepository()
        {
            objonlineshopingEntities3 = new onlineshopingEntities3();
        }

        public IEnumerable<SelectListItem> GetAllitems()
        {
            IEnumerable<SelectListItem> objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in objonlineshopingEntities3.items
                                  select new SelectListItem()
                                  {
                                      Text = obj.itemname,
                                      Value = obj.itemid.ToString(),
                                      Selected = false


                                  }).ToList();
            return objselectListItems;
        }
    }
}