using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.DigitalMenuRepo
{
    public class MenuRepo:IMenuRepo

    {
        public bool AddDish(MenuModel menuModel)
        {
            using (var context = new MenuDBContext())
            {
                //Menu menu = new Menu();

                //menu.DishName = menuModel.DishName;
                //menu.DishCategory = menuModel.DishCategory; 
                //menuModel.DishType = menuModel.DishType;
                //menuModel.DishDescription = menuModel.DishDescription;
                //menuModel.DishPrice = menuModel.DishPrice;
                //menuModel.DishQuantity = menuModel.DishQuantity;
                //menuModel.DishImageUrl = menuModel.DishImageUrl;
                //menuModel.CreatedOn = DateTime.UtcNow;

                var newdish = new Menu()
                {
                    DishCategory = menuModel.DishCategory,
                    DishName = menuModel.DishName,
                    DishDescription = menuModel.DishDescription,
                    DishType = (Menu.Type)menuModel.DishType,
                    DishPrice = menuModel.DishPrice,
                    DishQuantity = (Menu.Qunatity)menuModel.DishQuantity,
                    DishImageUrl = menuModel.DishImageUrl,
                    CreatedOn = DateTime.UtcNow
                };
                context.Add(newdish);
                context.SaveChanges();


                //context.Menus.Add(menu);
                //context.SaveChanges();
            }
                return true;

        }
        public List<Menu> ShowDishes()
        {
            List<Menu> returnList = new List<Menu>();
            using (var context = new MenuDBContext())
            {
                returnList = context.Menus.Select(menu => new Menu()
                {
                    DishName = menu.DishName,
                    DishCategory = menu.DishCategory,
                    DishType = menu.DishType,
                    DishDescription = menu.DishDescription,
                    DishPrice = menu.DishPrice,
                    DishQuantity = menu.DishQuantity,
                    DishImageUrl = menu.DishImageUrl,
                    DishId = menu.DishId

                }).ToList();

            }
            return returnList;
        }

    }
}
