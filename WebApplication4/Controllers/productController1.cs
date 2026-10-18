using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models.service;

namespace WebApplication4.Controllers
{
    public class productController1 : Controller
    {
        private Iproductservice _productService ;
        public productController1(Iproductservice productService)
        {
           this._productService = productService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WebApplication4.Models.product product)
        {
            _productService.AddProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id, WebApplication4.Models.product product)
        { 
            _productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(WebApplication4.Models.product product)
        {
            _productService.DeleteProduct(product.id);
            return RedirectToAction("Index");
        }
    }

}
