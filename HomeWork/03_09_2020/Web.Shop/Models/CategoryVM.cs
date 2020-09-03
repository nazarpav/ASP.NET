using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;

namespace Web.Shop.Models
{
    public class CategoryAddVM
    {
        [Display(Name = "Category name")]
        [Required(ErrorMessage ="enter name")]
        public string Name { get; set; }

        [Display(Name = "URL Slug")]
        [Required(ErrorMessage = "Enter slug")]
        public string UrlSlug { get; set; }

        [Display(Name = "Photo")]
        [Required(ErrorMessage = "Select photo")]
        public IFormFile Image { get; set; }
    }

    public class CategoryEditVM
    {
        [Display(Name = "Category name")]
        [Required(ErrorMessage = "Enter name")]
        public string Name { get; set; }

        [Display(Name = "URL Slug")]
        [Required(ErrorMessage = "Enter slug")]
        public string UrlSlug { get; set; }

        [Display(Name = "Select Photo")]
        public IFormFile ImageUpload { get; set; }

        [Display(Name = "Photo")]
        public string Image { get; set; }
    }
}
