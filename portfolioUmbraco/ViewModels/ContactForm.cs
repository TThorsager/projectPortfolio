using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace portfolioUmbraco.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Remember to enter your name, please")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Remember to enter your email address, please")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Enter a valid email, please")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Remember to enter a subject, please")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Remember to enter your message, please")]
        public string Message { get; set; }

    }
}