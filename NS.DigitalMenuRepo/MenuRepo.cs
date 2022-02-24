using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Menu GetDishById(int DishId)
        {
            //var context = new MenuDBContext();
            //var result = context.Menus.FromSqlRaw("USP_GetById @DishId", new SqlParameter("@DishId", DishId));
            //return (Menu)result;

            MenuDBContext context = new MenuDBContext();
            var menu = context.Menus.SingleOrDefault(x => x.DishId == DishId);
            return menu;
            //.Where(x => x.DishId == DishId).FirstOrDefault()
            //MenuDBContext context = new MenuDBContext();
            //var menu = context.Menus.Find(DishId);

            //if (menu != null)
            //{
            //    var menudetails = new Menu()
            //    {
            //        DishId = menu.DishId,
            //        DishName = menu.DishName,
            //        DishCategory = menu.DishCategory,
            //        DishType = (Menu.Type)menu.DishType,
            //        DishDescription = menu.DishDescription,
            //        DishPrice = menu.DishPrice,
            //        DishQuantity = (Menu.Qunatity)menu.DishQuantity,
            //        DishImageUrl = menu.DishImageUrl,
            //    };
            //    return menudetails;
            //}

            //return null;

        }

        public bool UpdateDish(Menu menu,int DishId)
        {
            //using (var context = new MenuDBContext())
            //{

            //    //Menu menu = new Menu();


            //    //menu.DishId = DishId;
            //    //menu.DishName = menuModel.DishName;
            //    //menu.DishCategory = menuModel.DishCategory;
            //    //menu.DishType = (Menu.Type)menuModel.DishType;
            //    //menu.DishDescription = menuModel.DishDescription;
            //    //menu.DishPrice = menuModel.DishPrice;
            //    //menu.DishQuantity = (Menu.Qunatity)menuModel.DishQuantity;
            //    //menu.DishImageUrl = menuModel.DishImageUrl;
            //    //context.Menus.Update(menu);
            //    context.Entry(menuModel).State = EntityState.Modified;
            //    context.SaveChanges();
            //}
            using (var context = new MenuDBContext())
            {
                var paraamList = new List<SqlParameter>();
                paraamList.Add(new SqlParameter("@DishId", menu.DishId));
                paraamList.Add(new SqlParameter("@DishName", menu.DishName));
                paraamList.Add(new SqlParameter("@DishCategory", menu.DishCategory));
                paraamList.Add(new SqlParameter("@DishType", menu.DishType));
                paraamList.Add(new SqlParameter("@DishDescription", menu.DishDescription));
                paraamList.Add(new SqlParameter("@DishPrice", menu.DishPrice));
                paraamList.Add(new SqlParameter("@DishQuantity", menu.DishQuantity));
                paraamList.Add(new SqlParameter("@DishImageUrl", menu.DishImageUrl));
                // paraamList.Add(new SqlParameter("@Describe", candidateModel.Describe));
                context.Database.ExecuteSqlRaw("USP_Update @DishId, @DishName, @DishDescription,@DishPrice,@DishCategory, @DishType, @DishQuantity, @DishImageUrl", paraamList);
            }
            return true;


        }
        public bool DeleteDish(Menu menu)
        {
            using (var context = new MenuDBContext())
            {
                var paraamList = new List<SqlParameter>();
                paraamList.Add(new SqlParameter("@DishId", menu.DishId));
                context.Database.ExecuteSqlRaw("USP_Delete @DishId", paraamList);

            }
                return true;
        }



    }
}
