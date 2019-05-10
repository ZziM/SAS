using SAS.Model;
using SAS.Model.Abstract;
using SAS.Repository.Repository.Abstract;
using SAS.Repository.Repository.Factual;
using SAS.Repository.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Repository.UnitOfWork.Factual
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly SecurityAreaSystemContext _db;

        private Lazy<IRepository<IEmployee>> EmployeeLazy { get; }
        private Lazy<IRepository<IEmployeeJTI>> EmployeeJTILazy { get; }
        private Lazy<IRepository<IContractor>> ContractorLazy { get; }
        private Lazy<IRepository<IGroup>> GroupLazy { get; }
        private Lazy<IRepository<IAccessPoint>> AccessPointLazy { get; }
        private Lazy<IRepository<IRequest>> RequestLazy { get; }
        private Lazy<IRepository<IRequestedGroup>> RequestedGroupLazy { get; }
        private Lazy<IRepository<IRequestedAccessPoint>> RequestedAccessPointLazy { get; }
        private Lazy<IRepository<IRequestState>> RequestStateLazy { get; }

        public IRepository<IEmployee> Employees => EmployeeLazy.Value;
        public IRepository<IEmployeeJTI> EmployeesJTI => EmployeeJTILazy.Value;
        public IRepository<IContractor> Contractors => ContractorLazy.Value; 
        public IRepository<IAccessPoint> AccessPoints => AccessPointLazy.Value;
        public IRepository<IGroup> Groups => GroupLazy.Value;

        public IRepository<IRequest> Requests => RequestLazy.Value;
        public IRepository<IRequestedGroup> RequestedGroups => RequestedGroupLazy.Value;
        public IRepository<IRequestedAccessPoint> RequestedAccessPoints => RequestedAccessPointLazy.Value;
        public IRepository<IRequestState> RequestStates => RequestStateLazy.Value;

        public EFUnitOfWork()
        {
            _db = new SecurityAreaSystemContext();

            EmployeeLazy = new Lazy<IRepository<IEmployee>>(() => new EmployeeRepository(_db));
            EmployeeJTILazy = new Lazy<IRepository<IEmployeeJTI>>(() => new EmployeeJTIRepository(_db));
            ContractorLazy = new Lazy<IRepository<IContractor>>(() => new ContractorRepository(_db));
            GroupLazy = new Lazy<IRepository<IGroup>>(() => new GroupRepository(_db));
            RequestLazy = new Lazy<IRepository<IRequest>>(() => new RequestRepository(_db));
            AccessPointLazy = new Lazy<IRepository<IAccessPoint>>(() => new AccessPointRepository(_db));
            RequestedGroupLazy = new Lazy<IRepository<IRequestedGroup>>(() => new RequestedGroupRepository(_db));
            RequestedAccessPointLazy = new Lazy<IRepository<IRequestedAccessPoint>>(() => new RequestedAccessPointRepository(_db));
            RequestStateLazy = new Lazy<IRepository<IRequestState>>(() => new RequestStateRepository(_db));
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
