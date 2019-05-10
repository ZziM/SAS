using SAS.Model.Abstract;

namespace SAS.Web.Models
{
    public class ComboBoxEmployeeViewModel
    {
        public int ID { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string FullName { get; set; }

        public ComboBoxEmployeeViewModel(IEmployee _)
        {
            ID = _.ID;
            Department = _.Department.Name;
            Company = _.Company.Name;
            FullName = string.Format("{0} {1} {2}", _.LastName, _.FirstName, _.MiddleName);
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}