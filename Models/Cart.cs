using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using OnlineStore.Models;

namespace OnlineStore.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        [ForeignKey("Product")]
        public int Product_id { get; set; }
        
        public virtual Product Product { get; set; }
        public DateTime Added_at { get; set; }
    }
}