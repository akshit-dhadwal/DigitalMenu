using NS.DigitalMenuData.Entities;
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
        //Add
        bool AddDish(MenuModel menuModel);

        //Read
        List<Menu> ShowDishes();

        //Delete
        Menu GetDishById(int DishId);

        //Update
        bool UpdateDish(Menu menu,int DishId);

        //Delete
        bool DeleteDish(MenuModel menuModel,int DishId);

        //List<StudentDeptModel> GetStudent();
    }
}
