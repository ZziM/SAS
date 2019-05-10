using SAS.Model.Factual;
using SAS.Service.Model;
using System.Linq;

namespace SAS.Service
{
    public class EmployeeJTIService : BaseService
    {
        public IQueryable<EmployeeJTIDTO> ReadAllActive()
        {
            return DB.EmployeeJTIRepository.ReadAll()
                .Where(_ => _.ActiveStatus == ActiveStatus.Enabled)
                .ToArray()
                .Select(_ => new EmployeeJTIDTO(_))
                .AsQueryable();
        }
    }
}
