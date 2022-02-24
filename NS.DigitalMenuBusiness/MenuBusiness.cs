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

        public Menu GetDishById(int Id)
        {
            return _imenutrepo.GetDishById(Id);

        }
        public bool UpdateDish(Menu menu)
        {
            return _imenutrepo.UpdateDish(menu);   
        }
    }
}
