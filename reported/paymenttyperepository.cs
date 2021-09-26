using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Web.Mvc;
using WebApplicationshop.Models;

namespace WebApplicationshop.reported
{
    public class paymenttyperepository
    {
        private onlineshopingEntities3 objonlineshopingEntities3;
        public paymenttyperepository()
        {
            objonlineshopingEntities3 = new onlineshopingEntities3();
        }

        public IEnumerable<SelectListItem> GetAllpaymenttypes()
        {
            IEnumerable<SelectListItem> objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in objonlineshopingEntities3.paymenttypes
                                  select new SelectListItem()
                                  {
                                      Text=obj.paymenttypename,
                                      Value=obj.paymenttypeid.ToString(),
                                      Selected=true

                                  }).ToList();
            return objselectListItems;
        }
    }
}