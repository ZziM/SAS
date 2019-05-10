using SAS.Model.Abstract;
using System;

namespace SAS.Service.Model
{
    public class EmployeeJTIDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string TabNumber { get; set; }
        public string SAPNumber { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public bool ActiveStatus { get; set; }
        public DateTime DLM { get; set; }
        public EmployeeJTIDTO(IEmployeeJTI _)
        {
            ID = _.ID;
            FirstName       = _.FirstName;
            MiddleName      = _.MiddleName;
            LastName        = _.MiddleName;
            TabNumber       = _.TabNumber;
            SAPNumber       = _.SAPNumber;
            DepartmentID    = _.Department.ID;
            DepartmentName  = _.Department.Name;
            CompanyID       = _.Company.ID;
            CompanyName     = _.Company.Name;
            ActiveStatus    = _.ActiveStatus == SAS.Model.Factual.ActiveStatus.Enabled;
        }
    }
}
