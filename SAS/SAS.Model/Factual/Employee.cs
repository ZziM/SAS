﻿using SAS.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAS.Model.Factual
{
    public abstract class Employee : User, IEmployee
    {
        public string Username { get; set; }
        IDepartment IEmployee.Department
        {
            get => Department;
            set
            {
                if(value is Department department)
                {
                    Department = department;
                    DepartmentID = department.ID;
                }
            }
        }
        ICompany IEmployee.Company
        {
            get => Company;
            set
            {
                if(value is Company company)
                {
                    Company = company;
                    CompanyID = company.ID;
                }
            }
        }

        public string SAPNumber { get; set; }

        #region EF
        public int DepartmentID { get; set; }
        public int CompanyID { get; set; }

        public virtual Department Department { get; set; }
        public virtual Company Company { get; set; }
        #endregion
    }
}