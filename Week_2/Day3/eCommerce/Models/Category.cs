﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}