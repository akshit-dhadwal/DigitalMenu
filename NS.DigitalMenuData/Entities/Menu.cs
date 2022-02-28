using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace NS.DigitalMenuData.Entities
{
    public  class Menu
    {
        //public int DishId { get; set; }
        //public string DishName { get; set; }
        //public string DishDescription { get; set; }
        //public int? DishPrice { get; set; }
        //public string DishCategory { get; set; }
        //public int? DishType { get; set; }
        //public int? DishQuantity { get; set; }
        //public string DishImageUrl { get; set; }
        //public DateTime? CreatedOn { get; set; }

        [Key]
        public int DishId { get; set; }


        [Required(ErrorMessage = "Please write the dish name")]
        [Display(Name = "Dish Name")]
        public string DishName { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(500, MinimumLength = 30)]
        public string DishDescription { get; set; }


        [Required(ErrorMessage = "Please add price ")]
        [Display(Name = "Price")]
        [Range(100,3000,ErrorMessage ="please add between 100 to 3000")]
        public int DishPrice { get; set; }


        [Display(Name = "Category")]
        public string DishCategory { get; set; }


        [Required(ErrorMessage = "Please choose the Type")]
        [Display(Name = "Type")]
        public Type DishType { get; set; }


        [Required(ErrorMessage = "Please choose the Quantity")]
        [Display(Name = "Quantity")]
        public Qunatity DishQuantity { get; set; }


        [NotMapped]
       [Required(ErrorMessage = "please upload the image for dish")]
        public IFormFile DishPhoto { get; set; }

        [Required(ErrorMessage = "plese upload the image for dish")]
        public string DishImageUrl { get; set; }

        public DateTime? CreatedOn { get; set; }

        public enum Type
        {
            Indian = 1,
            Chinese = 2,
            Italian = 3,
            Australian = 4,
            Thai = 5
        }

        public enum Qunatity
        {
            Full,
            Half

        }

    }
}
