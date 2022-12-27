using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLayer.Concrete
{
    public class Transformation
    {
        public int TransID { get; set; }

        public ICollection<Type> types { get; set; }
    }
}