using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using OnlineStore.Models;

namespace OnlineStore.ViewModels
{
    //this class is created to pass data of product and category together to a view
    //the props of product that are used in form ar added here to remove default data in form fields 
    public class ProductFormViewModel
    {
        // public Product Product { get; set; }
        public IEnumerable<Category> Categories { get; set; }



        public int? Id { get; set; }

        [Required]
        public String Name { get; set; }


        [Range(1, double.MaxValue, ErrorMessage = "You must Specify The Price")]
        [Required]
        public int? Price { get; set; }

        // [Required]
        public String Image { get; set; }
        public String description { get; set; }
       
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        

        [Update_image]
        [ Microsoft.Web.Mvc.FileExtensions(Extensions = ("png,jpg"),
             ErrorMessage = "Specify a png or jpg photo")]
        [Display(Name = "Product image")]
        public HttpPostedFileBase File { get; set; }

        public String Title
        {
            get
            {
                return Id == 0 ? "New Product" : "Edit Product";
            }
        }

        public ProductFormViewModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            description = product.description;
            CategoryId = product.CategoryId;
            Image = product.Image;

        }

        public ProductFormViewModel()
        {
            Id = 0;
        }



    }
}