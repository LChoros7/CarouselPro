using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarouselPro.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required]
        public string Path { get; set; }
        [Display(Name = "Caption Text")]
        public string CaptionText { get; set; }
        [Display(Name = "Alt Text")]
        public string AltText { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
    }
}