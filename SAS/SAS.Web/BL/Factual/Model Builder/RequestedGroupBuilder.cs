using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Abastract.Model_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAS.Web.BL.Factual.Model_Builder
{
    public class RequestedGroupBuilder : BaseModelBuilder<IRequestedGroup>
    {
        public RequestedGroupBuilder(IUnitOfWork db, IRequest request, int id) : base(db)
        {
            Item.Group = db.Groups.ReadAll().Single(_ => _.ID == id);
            Item.GroupStatus = RequestGroupStatus.OnApproval;
            Item.Request = request;
        }
    }
}