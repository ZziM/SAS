using SAS.Model.Abstract;
using System;

namespace SAS.Web.Models.Request
{
    public class RequestGroupViewModel
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string GroupType { get; private set; }
        public int GroupTypeID { get; private set; }

        public RequestGroupViewModel(IGroup group)
        {
            ID = group.ID;
            Name = group.Name;
            GroupType = group.Type.ToString();
            GroupTypeID = Convert.ToInt32(group.Type);
        }
    }
}