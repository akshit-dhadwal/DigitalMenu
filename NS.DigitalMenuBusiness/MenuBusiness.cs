using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using NS.DigitalMenuRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.DigitalMenuBusiness
{
   public class MenuBusiness : IMenuBusiness
    {
        private readonly IMenuRepo _imenutrepo = null;

        public MenuBusiness(IMenuRepo imenutrepo)
        {
            _imenutrepo = imenutrepo;
        }

        public bool AddDish(MenuModel menuModel)
        {
            return _imenutrepo.AddDish(menuModel);
        }

        public List<Menu> ShowDishes()
        {
            return _imenutrepo.ShowDishes();
        }

        public Menu GetDishById(int DishId)
        {
            return _imenutrepo.GetDishById(DishId);

        }
        public bool UpdateDish(MenuModel menuModel)
        {
            return _imenutrepo.UpdateDish(menuModel);   
        }
    }
}
