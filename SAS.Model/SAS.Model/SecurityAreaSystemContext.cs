﻿using SAS.Model.Factual;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model
{
    public class SecurityAreaSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<EmployeeJTI> EmployeesJTI { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public SecurityAreaSystemContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=SAS.DB;Integrated Security=True")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SecurityAreaSystemContext>(null);

            modelBuilder.Entity<User>()
                .ToTable("User", "usr")
                .HasKey(item => item.ID);

            modelBuilder.Entity<User>()
                .Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");

            modelBuilder.Entity<User>()
               .Map<Visitor>(item => item.Requires("UserTypeID").HasValue(Convert.ToInt32(UserType.Visitor)));

            modelBuilder.Entity<User>()
               .Map<EmployeeJTI>(item => item.Requires("UserTypeID").HasValue(Convert.ToInt32(UserType.JTI)))
               .Map<Contractor>(item => item.Requires("UserTypeID").HasValue(Convert.ToInt32(UserType.Contractor)));

            modelBuilder.Entity<Employee>()
                .HasRequired(item => item.Department)
                .WithMany(item => item.Employees)
                .HasForeignKey(item => item.DepartmentID);

            modelBuilder.Entity<Employee>()
                .HasRequired(item => item.Company)
                .WithMany(item => item.Employees)
                .HasForeignKey(item => item.CompanyID);

            modelBuilder.Entity<Company>()
                .ToTable("Company", "usr")
                .Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");

            modelBuilder.Entity<Department>()
                .ToTable("Department", "usr")
                .Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");
        }
    }
}
