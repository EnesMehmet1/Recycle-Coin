using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeSurname { get; set; }
        public ICollection<Type> types { get; set; }
    }
}