using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23_07_2020.Models
{
    public class UserVM
    {
        [Display(Name ="Name")]
        [Required(ErrorMessage = "Invalid name")]
        [MaxLength(16, ErrorMessage ="Max lenght is 16")]
        public string Name { get; set; }
        [Display(Name ="Surname")]
        [Required(ErrorMessage = "Invalid surname")]
        [MaxLength(16, ErrorMessage = "Max lenght is 16")]
        public string Surname { get; set; }
        [Display(Name ="Phone")]
        [Required(ErrorMessage = "Invalid phone number")]
        [MaxLength(32, ErrorMessage = "Max lenght is 32")]
        public string PhoneNumber { get; set; }
        [Display(Name ="Email")]
        [Required(ErrorMessage = "Invalid email")]
        [MaxLength(64, ErrorMessage = "Max lenght is 64")]
        public string Email { get; set; }
        [Display(Name ="Login")]
        [Required(ErrorMessage = "Invalid login")]
        [MaxLength(16, ErrorMessage = "Max lenght is 16")]
        public string Login { get; set; }
        [Display(Name ="Password")]
        [Required(ErrorMessage = "Invalid password")]
        [MaxLength(16, ErrorMessage = "Max lenght is 16")]
        public string Password { get; set; }
    }
}