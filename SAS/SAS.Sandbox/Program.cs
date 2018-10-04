using SAS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SecurityAreaSystemContext())
            {
                var users = db.Users.ToArray();
                var departments = db.Departments.ToArray();
                var companies = db.Companies.ToArray();
                var locations = db.Locations.ToArray();
                var groups = db.Groups.ToArray();
                var customers = db.Customers.ToArray();
                var requests = db.Requests.ToArray();
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}