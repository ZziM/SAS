using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAS.Web.Models.Request
{
    public class RequestVisitorViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int[] RequestedItemsID { get; set; }
        public string AdditionalInformation { get; set; }
        [Required]
        public string BusinessReason { get; set; }
        [Required]
        public Nullable<DateTime> StartAccessDate { get; set; }
        [Required]
        public Nullable<DateTime> EndAccessDate { get; set; }
    }
}