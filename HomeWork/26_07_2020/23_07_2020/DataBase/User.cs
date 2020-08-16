using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23_07_2020.DataBase
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string Name { get; set; }
        [Required]
        [MaxLength(16)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(32)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(64)]
        public string Email { get; set; }
        [Required]
        [MaxLength(16)]
        public string Login { get; set; }
        [Required]
        [MaxLength(16)]
        public string Password { get; set; }
    }
}