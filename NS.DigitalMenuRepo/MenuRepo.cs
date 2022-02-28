
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.DigitalMenuRepo
{
    public class MenuRepo : IMenuRepo

    {
        
        public bool AddDish(MenuModel menuModel)
        {
            using (var context = new MenuDBContext())
            {
               

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
 

            MenuDBContext context = new MenuDBContext();
            var menu = context.Menus.FirstOrDefault(x => x.DishId == DishId);

          
            return menu;

            
        }

        public bool UpdateDish(Menu menu, int DishId,string wwwrootpath)                    //update through stored procedure
        {
            if(menu.DishPhoto != null)
            {

                string imageFileName = Path.GetFileNameWithoutExtension(menu.DishPhoto.FileName);
                string imageFileExtension = Path.GetExtension(menu.DishPhoto.FileName);

                string imageName = imageFileName + imageFileExtension;

                string imagePath = Path.Combine(wwwrootpath + "/dishpictures", imageName);
                string imagePath1 = Path.Combine("/dishpictures", imageName);
                menu.DishPhoto.CopyTo(new FileStream(imagePath, FileMode.Create));

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
                    paraamList.Add(new SqlParameter("@DishImageUrl", imagePath1));

                    context.Database.ExecuteSqlRaw("USP_Update @DishId, @DishName, @DishDescription,@DishPrice,@DishCategory, @DishType, @DishQuantity, @DishImageUrl", paraamList);
                }
            }
            else
            {
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
                 //   paraamList.Add(new SqlParameter("@DishImageUrl", menu.DishImageUrl));

                    context.Database.ExecuteSqlRaw("uspupdate @DishId, @DishName, @DishDescription,@DishPrice,@DishCategory, @DishType, @DishQuantity", paraamList);
                }


            }
           

         
            return true;


        }
        public bool DeleteDish(MenuModel menuModel, int DishId)
        {
           
            using (var context = new MenuDBContext())
            {
               
                Menu menu = new Menu();
                menu.DishId = DishId;
                menu.DishName = menuModel.DishName;
                menu.DishCategory = menuModel.DishCategory;
                menu.DishType = (Menu.Type)menuModel.DishType;
                menu.DishDescription = menuModel.DishDescription;
                menu.DishPrice = menuModel.DishPrice;
                menu.DishQuantity = (Menu.Qunatity)menuModel.DishQuantity;
                menu.DishImageUrl = menuModel.DishImageUrl;
                menu.CreatedOn = menuModel.CreatedOn;

                context.Remove(menu);
                context.SaveChanges();

            }
            return true;
        }

        public List<Menu> SearchDish(string SearchBy,string search)

        {
            MenuDBContext context = new MenuDBContext();    
            List<Menu> list = new List<Menu>();
            

            if(SearchBy == null)
                return list = context.Menus.Where(x => x.DishCategory == search || search == null).ToList();  

            else if (SearchBy == "VEGITARIAN")
            

                return list = context.Menus.Where(x => x.DishCategory.Equals("VEGITARIAN")).ToList();

            else
            
                return list = context.Menus.Where(x => x.DishCategory.Equals("NON-VEGITARIAN")).ToList();
            
        }
    }
}
