using SAS.Web.BL.Abastract.Request;
using SAS.Web.BL.Abastract.Request.ApprovalProcess;
using SAS.Web.BL.Abastract.Request.RejectProcess;

namespace SAS.Web.BL.Factual.Request
{
    class RequestManager : IRequestManager
    {
        public void Approve(IApproveCommand command)
        {
            command.DoAction();
        }

        public void Reject(IRejectCommand command)
        {
            command.DoAction();
        }

        public void Dispose()
        {

        }
    }
}