using System;

namespace SAS.Model.Abstract
{
    public interface IRequestState
    {
        int ID { get; set; }
        string Name { get; set; }
        
        DateTime DLM { get; set; }
    }
}