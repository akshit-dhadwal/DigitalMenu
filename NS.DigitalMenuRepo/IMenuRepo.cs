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
        bool AddDish(MenuModel menuModel);

        List<Menu> ShowDishes();

        Menu GetDishById(int DishId);
        bool UpdateDish(Menu menu,int DishId);

        bool DeleteDish(Menu menu);

        //List<StudentDeptModel> GetStudent();
    }
}
