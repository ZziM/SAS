using SAS.Model.Abstract;

namespace SAS.Web.Models
{
    public class RequestAccessPointViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public RequestAccessPointViewModel(IAccessPoint accessPoint)
        {
            ID = accessPoint.ID;
            Name = accessPoint.Name;
        }
    }
}