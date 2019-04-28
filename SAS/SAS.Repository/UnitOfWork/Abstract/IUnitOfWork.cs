using SAS.Model.Abstract;
using SAS.Repository.Repository.Abstract;

namespace SAS.Repository.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<IEmployeeJTI> EmployeeJTIRepository { get; }
    }
}
