using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public class EmployeeJTI : Employee, IEmployeeJTI
    {
        public string TabNumber { get; set; }
    }
}
