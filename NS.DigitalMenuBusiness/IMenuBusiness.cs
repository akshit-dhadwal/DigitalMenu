using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.DigitalMenuBusiness
{
    public interface IMenuBusiness
    {
        bool AddDish(MenuModel menuModel);

        List<Menu> ShowDishes();

        Menu GetDishById(int Id);
        bool UpdateDish(Menu menu);

        //bool Delete(StudentModel studentModel, int Id);

        //List<StudentDeptModel> GetStudent();
    }
}
