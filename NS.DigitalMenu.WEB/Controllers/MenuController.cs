using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NS.DigitalMenuBusiness;
using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using System;
using System.IO;

namespace NS.DigitalMenu.WEB.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuBusiness _imenubusiness = null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MenuController(IMenuBusiness imenubusiness , IWebHostEnvironment webHostEnvironment)
        {
          _imenubusiness = imenubusiness;   
           _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddDish()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDish(MenuModel menuModel)
        {
            if (ModelState.IsValid)
            {
                if (menuModel.DishPhoto != null)
                {
                    string folder = "dish/dishpicture";
                    folder += Guid.NewGuid().ToString() + "-" + menuModel.DishPhoto.FileName;       //for uplodaing multiple images

                    menuModel.DishImageUrl = "/" + folder;
                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);    // used to recognise path during deployment 

                    menuModel.DishPhoto.CopyTo(new FileStream(serverFolder, FileMode.Create));
                }
                _imenubusiness.AddDish(menuModel);

                return RedirectToAction("AddDish", "Menu");

            }

            return View();
        }

        public IActionResult ShowDishes()
        {

            return View(_imenubusiness.ShowDishes());
        }

        public IActionResult UpdateDish(int Id)
        {
            return View(_imenubusiness.GetDishById(Id));
        }

       [HttpPost]
        public IActionResult UpdateDish(Menu menu,int DishId)
        {
            if (ModelState.IsValid)
            {
              

                _imenubusiness.UpdateDish(menu, DishId);

                return RedirectToAction("ShowDishes");

            }
            else
            {
                return View(menu);
            }
            
        }

        public IActionResult DeleteDish(int Id)
        {
            return View(_imenubusiness.GetDishById(Id));
        }

        [HttpPost]
        public IActionResult DeleteDish(MenuModel menuModel,int DishId)
        {
            _imenubusiness.DeleteDish(menuModel,DishId);
            return RedirectToAction("ShowDishes");
        }

        [HttpGet]
        public IActionResult SearchDishes(string SearchBy)
        {
            return View();
        }
    }
}
