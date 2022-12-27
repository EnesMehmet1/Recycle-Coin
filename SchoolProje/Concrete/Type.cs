using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLayer.Concrete
{
    public class Type
    {
        public int  TypeID { get; set; }
        public string  TypeName { get; set; }

        public int TransID { get; set; }
        public virtual Transformation transformation { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}