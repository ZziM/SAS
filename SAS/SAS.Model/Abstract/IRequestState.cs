using SAS.Model.Factual;
using System;

namespace SAS.Model.Abstract
{
    public interface IRequestState
    {
        int ID { get; set; }
        string Name { get; set; }
        EnumRequestState State { get; }
        DateTime DLM { get; set; }
    }
}