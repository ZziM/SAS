using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public class RequestJTI : Request, IRequestJTI
    {
        public override RequestType Type => RequestType.JTI;
    }
}
