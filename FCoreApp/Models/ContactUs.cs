using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FCoreApp.Models
{
    public class ContactUs
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a valid Name")]
        [MinLength(5, ErrorMessage = "Minimum Length 5 Character")]
        [StringLength(15, ErrorMessage = "Maximum Length 15 Character")]
        [DisplayName("Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Your Email")]
        [EmailAddress(ErrorMessage ="Enter Valid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a valid Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please enter a valid Message")]
        public string Message { get; set; }
    }
}
