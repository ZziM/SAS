using SAS.Model.Abstract;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Abastract.Model_Builder;
using SAS.Web.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAS.Web.BL.Factual.Model_Builder
{
    public class CustomerContractorBuilder : BaseModelBuilder<ICustomerContractor>
    {
        public CustomerContractorBuilder(IUnitOfWork db, RequestWorkedContractorViewModel model) : base(db)
        {
            var customerEmployee = db.Contractors.ReadAll()
              .Single(_ => _.ID == model.CustomerID);

            Item.FirstName = customerEmployee.FirstName;
            Item.MiddleName = customerEmployee.MiddleName;
            Item.LastName = customerEmployee.LastName;
            Item.SAPNumber = customerEmployee.SAPNumber;
            Item.Username = customerEmployee.Username;
            Item.Department = customerEmployee.Department.Name;
            Item.Company = customerEmployee.Company.Name;
        }
    }
}