using System;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Product
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public string  product_image { get; set; }
        
        [DataType(DataType.Date)] 
        public DateTime ExpiredDateTime { get; set; }
        public int  quantity { get; set; }
    }
}