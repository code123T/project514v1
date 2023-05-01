using System;

namespace WebShopping.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpDateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}