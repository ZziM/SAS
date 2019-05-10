using SAS.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAS.Web.Models.Request
{
    public class RequestViewModel
    {
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Creator { get; set; }
        public string RequestType { get; set; }
        public DateTime StartAccessDate { get; set; }
        public Nullable<DateTime> EndAccessDate { get; set; }
        public string RequestAccess { get; set; }

        public RequestViewModel(IRequest request)
        {
            Name = request.ToString();
            Customer = $"{request.Customer.LastName}, {request.Customer.FirstName}";
            Creator = $"{request.Creator.LastName}, {request.Creator.FirstName}";
            StartAccessDate = request.StartAccessDate;
            EndAccessDate = request.EndAccessDate;
        }
    }
}