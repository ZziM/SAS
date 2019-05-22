using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public class RequestContractor : Request, IRequestContractor
    {
        public override RequestType Type => RequestType.Contractor;
    }
}
