using SAS.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Factual
{
    public abstract class Request : DbObject, IRequest
    {
        IEmployee IRequest.Creator
        {
            get => Creator;
            set
            {
                if (value is Employee creator)
                {
                    Creator = creator;
                    CreatorID = creator.ID;
                }
            }
        }
        ICustomer IRequest.Customer
        {
            get => Customer;
            set
            {
                if (value is Customer customer)
                {
                    Customer = customer;
                    CustomerID = customer.ID;
                }
            }
        }
        public string Name { get; set; }
        public string AdditionalInformation { get; set; }
        public string BusinessReason { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartAccessDate { get; set; }
        public DateTime? EndAccessDate { get; set; }

        #region EF
        public int CustomerID { get; set; }
        public virtual Customer Customer {get;set;}
        public int CreatorID { get; set; }
        public virtual Employee Creator { get; set; }
        #endregion
    }
}
