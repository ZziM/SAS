namespace SAS.Model.Abstract
{
    public interface IEmployeeJTI : IEmployee
    {
        string TabNumber { get; set; }
        string SAPNumber { get; set; }
    }
}
