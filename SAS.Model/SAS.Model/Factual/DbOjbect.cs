using SAS.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace SAS.Model.Factual
{
    public abstract class DbOjbect : IDbObject
    {
        public int ID { get; set; }
        public ActiveStatus ActiveStatus { get; set; }
        public DateTime DLM { get; set; }
    }
}
