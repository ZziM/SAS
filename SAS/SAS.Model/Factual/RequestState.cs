using SAS.Model.Abstract;
using System;

namespace SAS.Model.Factual
{
    public class RequestState : IRequestState
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public EnumRequestState State
        {
            get
            {
                if(Enum.IsDefined(typeof(EnumRequestState), ID))
                {
                    return (EnumRequestState)ID;
                }
                else
                {
                    return EnumRequestState.None;
                }
            }
        }
        
        public DateTime DLM { get; set; }
    }
}
