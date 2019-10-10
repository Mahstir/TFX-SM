using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FX.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public Plan Plan { get; set; }


        public double? Amount { get; set; }


        [Display(Name = "Payment Plan")]
        public byte PlanId { get; set; }

        [Display(Name = "Date of Payment")]
        public DateTime? DateOfpayment { get; set; }

        [Display(Name = "Date of Return")]
        public DateTime? DateOfReturn { get; set; }

        public string UserId { get; set; }
    }
}