﻿namespace WebShopping.Models.Entity
{
    internal class SiteInfo : BaseEntity
    {
        public string? Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}