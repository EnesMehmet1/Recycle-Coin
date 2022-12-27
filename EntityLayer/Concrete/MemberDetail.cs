using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLayer.Concrete
{
    public class MemberDetail
    {
        public int MemberDetailID { get; set; }
        public ICollection<Member> members { get; set; }
    }
}