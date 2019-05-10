using SAS.Web.BL.Abastract.Request.ApprovalProcess;
using SAS.Web.BL.Abastract.Request.RejectProcess;
using System;

namespace SAS.Web.BL.Abastract.Request
{
    public interface IRequestManager : IDisposable
    {
        void Approve(IApproveCommand command);
        void Reject(IRejectCommand command);
    }
}