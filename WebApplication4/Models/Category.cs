﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Category
    {
        public Int64 Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
