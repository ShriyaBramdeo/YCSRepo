using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YCS.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int StaffId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string StaffName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public long ContactNumber { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string ClientAddress { get; set; }

        [Required]
        [Display(Name = "Staff Type")]
        public string StaffType { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}