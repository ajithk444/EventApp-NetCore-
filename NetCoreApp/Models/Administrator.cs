﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
    public class Administrator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public int Phone { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Username cannot be longer than 15 characters.")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string RegisterAdminCode { get; set; }

        [Required]
        public virtual List<Event> Events { get; set; }
    }
}
