using SAS.Model.Abstract;
using System.Text.RegularExpressions;

namespace SAS.Web.Models
{
    public class RequestedGroupViewModel
    {
        public int RequestID { get; set; }
        public int GroupID { get; private set; }
        public string Name { get; private set; }
        public string GroupType { get; private set; }
        public string GroupStatus { get; set; }

        public RequestedGroupViewModel(IRequestedGroup group)
        {
            RequestID = group.Request.ID;
            GroupID = group.Group.ID;
            Name = group.Group.Name;
            GroupType = group.Group.Type.ToString();
            GroupStatus = Regex.Replace(group.GroupStatus.ToString(), "([a-z])([A-Z])", "$1 $2");
        }
    }
}