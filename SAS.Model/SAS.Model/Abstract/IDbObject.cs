using SAS.Model.Factual;
using System;

namespace SAS.Model.Abstract
{
    public interface IDbObject
    {
        int ID { get; set; }
        ActiveStatus ActiveStatus { get; set; }
        DateTime DLM { get; set; }
    }
}