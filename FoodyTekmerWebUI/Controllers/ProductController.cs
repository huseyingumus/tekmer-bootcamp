﻿using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetAllList();
            return View(values);
        }

        public IActionResult CreateProduct()
        {
            // temiz kod ezildi

            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            // temiz kod ezildi
            product.Status = true;
            _productService.TAdd(product);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _productService.TGetById(id);
            
            return RedirectToAction("Index");
        }





        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            product.Status = true;
            _productService.TUpdate(product);
            
            return RedirectToAction("Index");
        }

    }
}
