﻿using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.DigitalMenuRepo
{
    public interface IMenuRepo
    {
       
        bool AddDish(MenuModel menuModel);

        List<Menu> ShowDishes();

        Menu GetDishById(int DishId);
        bool UpdateDish(Menu menu,int DishId,string wwwrootpath);

        bool DeleteDish(MenuModel menuModel,int DishId);

        List<Menu> SearchDish(string SearchBy, string search);
    }
}
