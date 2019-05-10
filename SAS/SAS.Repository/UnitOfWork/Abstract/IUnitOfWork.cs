using SAS.Model.Abstract;
using SAS.Repository.Repository.Abstract;

namespace SAS.Repository.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<IEmployee> Employees { get; }
        IRepository<IEmployeeJTI> EmployeesJTI { get; }
        IRepository<IContractor> Contractors { get; }
        IRepository<IGroup> Groups { get; }
        IRepository<IAccessPoint> AccessPoints { get; }
        IRepository<IRequest> Requests { get; }
        IRepository<IRequestedGroup> RequestedGroups { get; }
        IRepository<IRequestedAccessPoint> RequestedAccessPoints { get; }
        IRepository<IRequestState> RequestStates { get; }

        void Save();
    }
}
