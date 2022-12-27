using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLayer.Concrete
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public int MemberShaNumber { get; set; }
        public int MemberCarbonQuantity { get; set; }

        public int MemberDetailID { get; set; }
        public virtual MemberDetail MemberDetail { get; set; }
    }
}