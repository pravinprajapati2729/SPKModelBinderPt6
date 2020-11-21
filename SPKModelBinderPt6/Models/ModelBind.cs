using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPKModelBinderPt6.Models
{
    public class CustomerBinding : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            string strCustomerCode = objContext.Request.Form["txtCustomerCode"];
            string strCustomerName = objContext.Request.Form["txtCustomerName"];
            Customer objcust = new Customer()
            {
                CustomerCode = strCustomerCode,
                CustomerName = strCustomerName
            };
            return objcust;
        }
    }
}