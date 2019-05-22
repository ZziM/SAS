using SAS.Model.Abstract;
using System;
using System.Text.RegularExpressions;

namespace SAS.Web.Models.Request
{
    public class RequestViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Creator { get; set; }
        public DateTime StartAccessDate { get; set; }
        public Nullable<DateTime> EndAccessDate { get; set; }
        public string AdditionalInformation { get; set; }
        public string BusinessReason { get; set; }
        public string RequestAccess { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        
        public RequestViewModel(IRequest request)
        {
            ID = request.ID;
            Name = request.ToString();
            FirstName = request.Customer.FirstName;
            MiddleName = request.Customer.MiddleName;
            LastName = request.Customer.LastName;
            Creator = $"{request.Creator.LastName}, {request.Creator.FirstName}";
            StartAccessDate = request.StartAccessDate;
            EndAccessDate = request.EndAccessDate;
            State = Regex.Replace(request.State.ToString(), "([a-z])([A-Z])", "$1 $2");
            Type = request.Type.ToString();
            AdditionalInformation = request.AdditionalInformation;
            BusinessReason = request.BusinessReason;
        }
    }
}