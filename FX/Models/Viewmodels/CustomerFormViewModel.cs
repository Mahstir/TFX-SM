using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FX.Models.Viewmodels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Plan> Plans { get; set; }
        public Customer Customer { get; set; }



    }
}