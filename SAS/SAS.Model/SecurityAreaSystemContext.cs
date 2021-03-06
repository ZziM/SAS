﻿using SAS.Model.Factual;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model
{
    public class SecurityAreaSystemContext : DbContext
    {
        #region DbSets
        public DbSet<User>                  Users                   { get; set; }
        public DbSet<Employee>              Employees               { get; set; }
        public DbSet<Visitor>               Visitors                { get; set; }
        public DbSet<EmployeeJTI>           EmployeesJTI            { get; set; }
        public DbSet<Contractor>            Contractors             { get; set; }
        public DbSet<Department>            Departments             { get; set; }
        public DbSet<Company>               Companies               { get; set; }
        public DbSet<AccessPoint>           AccessPoints            { get; set; }
        public DbSet<Group>                 Groups                  { get; set; }
        public DbSet<Customer>              Customers               { get; set; }
        public DbSet<CustomerEmployee>      CustomerEmployees       { get; set; }
        public DbSet<CustomerContractor>    CustomerContractors     { get; set; }
        public DbSet<CustomerJTI>           CustomersJTI            { get; set; }
        public DbSet<Request>               Requests                { get; set; }
        public DbSet<RequestJTI>            GetRequestsJTI          { get; set; }
        public DbSet<RequestContractor>     RequestContractors      { get; set; }
        public DbSet<RequestVisitor>        RequestVisitors         { get; set; }
        public DbSet<RequestedAccessPoint>  RequestedAccessPoints   { get; set; }
        public DbSet<RequestedGroup>        RequestedGroups         { get; set; }
        public DbSet<RequestState>          RequestStates { get; set; }
        #endregion

        #region ctor
        public SecurityAreaSystemContext() : base(@"Data Source=DESKTOP-3DQTH1F\SQLEXPRESS;Initial Catalog=SAS;Integrated Security=True")
        {

        }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SecurityAreaSystemContext>(null);

            modelBuilder.Configurations.Add(new UserConfiguration()                 );
            modelBuilder.Configurations.Add(new EmployeeConfiguration()             );
            modelBuilder.Configurations.Add(new CompanyConfiguration()              );
            modelBuilder.Configurations.Add(new DepartmentConfiguration()           );
            modelBuilder.Configurations.Add(new LocationConfiguration()             );
            modelBuilder.Configurations.Add(new GroupConfiguration()                );
            modelBuilder.Configurations.Add(new CustomerConfiguration()             );
            modelBuilder.Configurations.Add(new RequestConfiguration()              );
            modelBuilder.Configurations.Add(new RequestedAccessPointConfiguration() );
            modelBuilder.Configurations.Add(new RequestedGroupConfiguration()       );
            modelBuilder.Configurations.Add(new RequestStateConfiguration()         );
        }

        class UserConfiguration             : EntityTypeConfiguration<User>
        {
            public UserConfiguration()
            {
                ToTable("User", "usr")
                .HasKey(item => item.ID);

                Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");

                Map<Visitor>(item =>
                {
                    item.Requires("UserTypeID").HasValue(Convert.ToInt32(UserType.Visitor));
                });
                Map<EmployeeJTI>(item =>
                {
                    item.Requires("UserTypeID").HasValue(Convert.ToInt32(UserType.JTI));
                });
                Map<Contractor>(item =>
                {
                    item.Requires("UserTypeID").HasValue(Convert.ToInt32(UserType.Contractor));
                });
            }
        }
        class EmployeeConfiguration         : EntityTypeConfiguration<Employee>
        {
            public EmployeeConfiguration()
            {
                HasRequired(item => item.Department)
                    .WithMany(item => item.Employees)
                    .HasForeignKey(item => item.DepartmentID);


                HasRequired(item => item.Company)
                .WithMany(item => item.Employees)
                .HasForeignKey(item => item.CompanyID);
            }
        }
        class CompanyConfiguration          : EntityTypeConfiguration<Company>
        {
            public CompanyConfiguration()
            {
                ToTable("Company", "usr")
                .Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");
            }
        }
        class DepartmentConfiguration       : EntityTypeConfiguration<Department>
        {
            public DepartmentConfiguration()
            {
                ToTable("Department", "usr")
                .Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");
            }
        }
        class LocationConfiguration         : EntityTypeConfiguration<AccessPoint>
        {
            public LocationConfiguration()
            {
                ToTable("AccessPoint", "loc")
                .Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");

                HasMany(item => item.AccessPointManagers)
                .WithMany()
                .Map(llm =>
                {
                    llm.MapLeftKey("UserID");
                    llm.MapRightKey("AccessPointID");
                    llm.ToTable("AccessPointManager", "loc");
                });
            }
        }
        class GroupConfiguration            : EntityTypeConfiguration<Group>
        {
            public GroupConfiguration()
            {
                ToTable("Group", "loc");

                Property(item => item.ActiveStatus)
                .HasColumnName("ActiveStatusID");

                Property(item => item.Type)
                .HasColumnName("GroupTypeID");

                HasMany(item => item.AccessPoints)
                .WithMany(item => item.Groups)
                .Map(la =>
                {
                    la.MapLeftKey("GroupID");
                    la.MapRightKey("AccessPointID");
                    la.ToTable("GroupToAccessPoint", "loc");
                });
            }
        }
        class CustomerConfiguration         : EntityTypeConfiguration<Customer>
        {
            public CustomerConfiguration()
            {
                ToTable("Customer", "rqs");
                Property(item => item.ActiveStatus)
                    .HasColumnName("ActiveStatusID");

                Map<CustomerVisitor>(item =>
                {
                    item.Requires("CustomerTypeID").HasValue(Convert.ToInt32(CustomerType.Visitor));
                });
                Map<CustomerContractor>(item =>
                {
                    item.Requires("CustomerTypeID").HasValue(Convert.ToInt32(CustomerType.Contractor));
                });
                Map<CustomerJTI>(item =>
                {
                    item.Requires("CustomerTypeID").HasValue(Convert.ToInt32(CustomerType.JTI));
                });
            }
        }
        class CustomerEmployeeConfiguration : EntityTypeConfiguration<CustomerEmployee>
        {
            public CustomerEmployeeConfiguration()
            {

            }
        }
        class RequestConfiguration          : EntityTypeConfiguration<Request>
        {
            public RequestConfiguration()
            {
                ToTable("Request", "rqs");
                Property(item => item.ActiveStatus)
                    .HasColumnName("ActiveStatusID");

                Ignore(_ => _.Type);

                Property(_ => _.RequestAccess)
                    .HasColumnName("RequestAccessID");

                Property(_ => _.State)
                    .HasColumnName("RequestStateID");

                Map<RequestJTI>(item =>
                {
                    item.Requires("RequestTypeID").HasValue(Convert.ToInt32(RequestType.JTI));
                });
                Map<RequestContractor>(item =>
                {
                    item.Requires("RequestTypeID").HasValue(Convert.ToInt32(RequestType.Contractor));
                });
                Map<RequestVisitor>(item =>
                {
                    item.Requires("RequestTypeID").HasValue(Convert.ToInt32(RequestType.Visitor));
                });

                HasRequired(item => item.Creator)
                    .WithMany()
                    .HasForeignKey(item => item.CreatorID);
                HasRequired(item => item.Customer)
                    .WithMany()
                    .HasForeignKey(item => item.CustomerID);

                HasMany(_ => _.Groups)
                    .WithRequired(_ => _.Request)
                    .HasForeignKey(_ => _.RequestID);
            }
        }

        class RequestedGroupConfiguration : EntityTypeConfiguration<RequestedGroup>
        {
            public RequestedGroupConfiguration()
            {
                ToTable("RequestedGroup", "rqs")
                    .HasKey(_ => _.ID);
                Property(_ => _.ID)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(_ => _.GroupStatus)
                    .HasColumnName("GroupStatusID");

                HasRequired(_ => _.Request)
                    .WithMany()
                    .HasForeignKey(_ => _.RequestID);

                Property(_ => _.ActiveStatus)
                        .HasColumnName("ActiveStatusID");

                HasRequired(_ => _.Group)
                    .WithMany()
                    .HasForeignKey(_ => _.GroupID);
            }
        }

        class RequestedAccessPointConfiguration : EntityTypeConfiguration<RequestedAccessPoint>
        {
            public RequestedAccessPointConfiguration()
            {
                ToTable("RequestedAccessPoint", "rqs")
                    .HasKey(_ => _.ID);
                Property(_ => _.ID)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                HasRequired(_ => _.Group)
                    .WithMany(_ => _.AccessPoints)
                    .HasForeignKey(_ => _.RequestedGroupID);

                Property(_ => _.AccessPointStatus)
                    .HasColumnName("AccessPointStatusID");

                Property(_ => _.ActiveStatus)
                    .HasColumnName("ActiveStatusID");

                HasOptional(_ => _.AccessPoint)
                    .WithMany()
                    .HasForeignKey(_ => _.AccessPointID);
            }
        }

        class RequestStateConfiguration : EntityTypeConfiguration<RequestState>
        {
            public RequestStateConfiguration()
            {
                ToTable("RequestState", "rqs");

                HasKey(_ => _.ID);
                Ignore(_ => _.State);
            }
        }
    }
}
