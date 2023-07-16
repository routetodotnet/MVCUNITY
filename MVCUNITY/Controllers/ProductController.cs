using MVCUNITY.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUNITY.Controllers
{
    //next weekend- no class
    //mvc jquery-step practice.
    //WebApi...monday- 7pm
    //Testing - Recap
    //.Net Core.-Wednes - 7pm 
      //.net core mvc
      //.net webapi..
    //azure..
    //

    //Angular/react


    //Orders
    //customer
    //STudent..
    public class ProductController : Controller
    {
        //Single Responsiblity Principle.
        public IProductRep productRep;
        //Unity Container.
        //Constructor interface injection
        public ProductController(IProductRep productRep1)
        {
            productRep = productRep1;
            //logger object
        }

        // GET: Product/GetAllProducts
        public ActionResult GetAllProducts()
        {
            //validation
            //...
            //ProductRepository productRepository = new ProductRepository();
             var productslst= productRep.GetAll();

            return View(productslst);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            // ProductRepository productRepository = new ProductRepository();
            productRep.Delete(id);

            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
