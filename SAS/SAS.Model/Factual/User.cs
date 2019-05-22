﻿using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public abstract class User : DbObject, IUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}