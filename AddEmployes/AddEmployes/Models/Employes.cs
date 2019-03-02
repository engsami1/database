using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddEmployes.Models
{
    public class Employes
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = " Employe Name")]
        public string NameEmploye { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Employe Age")]
        public int AgeEmp { get; set; }

        [Required]
        [Display(Name ="Employe Gender")]
        public String GenderEmp { get; set; }
    }
}