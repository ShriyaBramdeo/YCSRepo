using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YCS.Models
{
    public class Orders
    {
        [Key]
       
        public int OrderId { get; set; }

        public virtual Client Client { get; set; }
        public string ClientName { get; set; }

        
        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public long ContactNumber { get; set; }

        [Required]
        [Display(Name = "Client Address")]
        public string ClientAddress { get; set; }

        [Required]
        [Display(Name = "Quotation")]
        public double Quotation { get; set; }


        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; }
    }
}