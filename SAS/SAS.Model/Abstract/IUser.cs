namespace SAS.Model.Abstract
{
    public interface IUser : IDbObject
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
    }
}
