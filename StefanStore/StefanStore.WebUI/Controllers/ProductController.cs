using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StefanStore.Domain.Abstract.UnitOfWork;

namespace StefanStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork _uow;

        public ProductController(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        public ActionResult ListProducts()
        {
            return View(_uow.Products.GetAll());
        }

    }
}
