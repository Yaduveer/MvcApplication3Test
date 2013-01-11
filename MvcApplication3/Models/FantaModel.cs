﻿using System.ComponentModel.DataAnnotations;

namespace MvcApplication3.Models
{
    public class FantaModel
    {
        [Required]
        public Drinker Drinker { get; set; }
        
        [Required]
        public bool IsLoved { get; set; }
    }
}
