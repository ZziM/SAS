using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAS.Web.Models.Request
{
    public class RequestWorkedContractorViewModel
    {
        [Required]
        public int CreatorID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public string AdditionalInformation { get; set; }
        [Required]
        public string BusinessReason { get; set; }
        [Required]
        public DateTime StartAccessDate { get; set; }
        public DateTime EndAccessDate { get; set; }
        public int[] RequestedItemsID { get; set; }
    }
}