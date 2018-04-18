using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YCS.Models
{
    public class Salary
    {
        [Key]
        [Required]
        public string Id { get; set; }

        public virtual Employee Employee { get; set; }
        public string StaffName { get; set; }

       [Required]
        [Display(Name = "Basic")]
        public double Basic { get; set; }

        [Required]
        [Display(Name = "Overtime")]
        public double Overtime { get; set; }

        [Required]
        [Display(Name = "Tax")]
        public double Tax { get; set; }

        [Required]
        [Display(Name = "Total")]
        public double Toatal { get; set; }

        

    }
}