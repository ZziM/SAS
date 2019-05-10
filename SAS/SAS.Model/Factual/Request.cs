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

        IQueryable<IRequestedGroup> IRequest.Groups
        {
            get
            {
                return Groups.AsQueryable();
            }
        }

        public string AdditionalInformation { get; set; }
        public string BusinessReason { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartAccessDate { get; set; }
        public DateTime? EndAccessDate { get; set; }
        public RequestAccess RequestAccess { get; set; }
        IRequestState IRequest.RequestState
        {
            get => RequestState;
            set
            {
                if(value is RequestState requestState)
                {
                    RequestState = requestState;
                    RequestStateID = requestState.ID;
                }
            }
        }

        #region EF
        public int RequestStateID { get; set; }
        public virtual RequestState RequestState { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer {get;set;}
        public int CreatorID { get; set; }
        public virtual Employee Creator { get; set; }
        public virtual ICollection<RequestedGroup> Groups { get; set; }
        #endregion

        public Request()
        {
            Groups = new HashSet<RequestedGroup>();
        }

        public override string ToString()
        {
            return $"RQST-{ID}";
        }
    }
}
