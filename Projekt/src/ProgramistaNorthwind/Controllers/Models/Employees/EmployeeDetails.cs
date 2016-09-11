using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramistaNorthwind.Controllers.Models.Employees
{
    public class EmployeeDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string DateOfHire { get; set; }
        public string Image { get; internal set; }
    }
}
