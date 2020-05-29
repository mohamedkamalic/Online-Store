using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Store.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        public int Number_of_products { get; set; }

    }
}