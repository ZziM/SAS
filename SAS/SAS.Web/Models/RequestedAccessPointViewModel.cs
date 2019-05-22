using SAS.Model.Abstract;
using System.Text.RegularExpressions;

namespace SAS.Web.Models
{
    public class RequestedAccessPointViewModel
    {
        public int AccessPointID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public bool HasPermissions { get; set; }
        public RequestedAccessPointViewModel(IRequestedAccessPoint accessPoint)
        {
            AccessPointID = accessPoint.AccessPoint.ID;
            Name = accessPoint.AccessPoint.Name;
            Status = Regex.Replace(accessPoint.AccessPointStatus.ToString(), "([a-z])([A-Z])", "$1 $2");
            HasPermissions = true;
        }
    }
}