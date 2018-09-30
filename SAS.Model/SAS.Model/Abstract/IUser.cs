using SAS.Model.Factual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Abstract
{
    public interface IUser : IDbObject
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
    }
}
