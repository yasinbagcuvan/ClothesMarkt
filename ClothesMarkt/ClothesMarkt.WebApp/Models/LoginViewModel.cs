﻿using System.ComponentModel.DataAnnotations;

namespace ClothesMarkt.WebApp.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
