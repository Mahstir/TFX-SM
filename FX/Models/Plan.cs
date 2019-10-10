using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FX.Models
{
    public class Plan
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public float DailyInterest { get; set; }
        public double Rate { get; set; }
        public byte DurationInDays { get; set; }
        

    }
}