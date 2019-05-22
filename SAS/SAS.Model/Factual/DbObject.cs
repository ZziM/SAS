using SAS.Model.Abstract;
using System;

namespace SAS.Model.Factual
{
    public abstract class DbObject : IDbObject
    {
        public int ID { get; set; }
        public ActiveStatus ActiveStatus { get; set; }
        public DateTime DLM { get; set; }
    }
}