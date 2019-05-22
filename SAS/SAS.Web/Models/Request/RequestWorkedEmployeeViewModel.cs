using System;
using System.ComponentModel.DataAnnotations;

namespace SAS.Web.Models.Request
{
    public class RequestWorkedEmployeeViewModel
    {

        [Required]
        public string Creator { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public int[] RequestedItemsID { get; set; }
        [Required]
        public DateTime StartAccessDate { get; set; }
        public Nullable<DateTime> EndAccessDate { get; set; }
        public string AdditionalInformation { get; set; }
        [Required]
        public string BusinessReason { get; set; }
    }
}