
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }


        [Required]
        public String Name { get; set; }


        [Range(1, double.MaxValue, ErrorMessage = "You must Specify The Price")]
        public int Price { get; set; }

        // [Required]
        public String Image { get; set; }
        public String description { get; set; }
    }
}