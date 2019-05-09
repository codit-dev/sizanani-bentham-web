using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SizananiBentham.Models
{
    
    public class ContactViewModel
    {
        [Required, Display(Name = "Name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Subject { get; set; }
        [Display(Name = "Phone")]
        public string FromPhoneNumber { get; set; }
        [Required]
        public string Message { get; set; }
    }
    
}