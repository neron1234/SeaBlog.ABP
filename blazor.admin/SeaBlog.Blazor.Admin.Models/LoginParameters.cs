using System;
using System.ComponentModel.DataAnnotations;

namespace SeaBlog.Blazor.Admin.Models
{
    public class LoginParameters
    {
        [Required]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberClient { get; set; }
    }
}
