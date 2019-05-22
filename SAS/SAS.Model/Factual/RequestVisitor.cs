using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public class RequestVisitor : Request, IRequestVisitor
    {
        public override RequestType Type => RequestType.Visitor;
    }
}
