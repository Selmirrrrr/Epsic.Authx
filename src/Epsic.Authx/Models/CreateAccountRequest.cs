﻿using System.ComponentModel.DataAnnotations;

namespace Epsic.Authx.Models
{
    public class CreateAccountRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool IsMedecin { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }
}