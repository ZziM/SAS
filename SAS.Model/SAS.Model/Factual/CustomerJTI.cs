using SAS.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Factual
{
    public class CustomerJTI : CustomerEmployee, ICustomerJTI
    {
        public string TabNumber { get; set; }
    }
}
