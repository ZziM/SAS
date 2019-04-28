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

        private Lazy<IRepository<IEmployeeJTI>> EmployeeJTILazy { get; }

        public IRepository<IEmployeeJTI> EmployeeJTIRepository => EmployeeJTILazy.Value;

        public EFUnitOfWork()
        {
            _db = new SecurityAreaSystemContext();

            EmployeeJTILazy = new Lazy<IRepository<IEmployeeJTI>>(() => new EmployeeJTIRepository(_db));
        }
    }
}
