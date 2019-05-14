using SAS.Model.Abstract;
using System;

namespace SAS.Web.Models.Request
{
    public class RequestViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Creator { get; set; }
        public string RequestType { get; set; }
        public DateTime StartAccessDate { get; set; }
        public Nullable<DateTime> EndAccessDate { get; set; }
        public string RequestAccess { get; set; }

        public RequestViewModel(IRequest request)
        {
            ID = request.ID;
            Name = request.ToString();
            Customer = $"{request.Customer.LastName}, {request.Customer.FirstName}";
            Creator = $"{request.Creator.LastName}, {request.Creator.FirstName}";
            StartAccessDate = request.StartAccessDate;
            EndAccessDate = request.EndAccessDate;
        }
    }
}