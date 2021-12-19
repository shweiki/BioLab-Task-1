using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class PremiumsDiscountsStaff
    {

        public int empno { get; set; }
        public string FullAnname { get; set; }
        public string desc { get; set; }
        public DateTime  fromdate{ get; set; }
        public DateTime todate { get; set; }
        public decimal value { get; set; }
    
      
        public PremiumsDiscountsStaff()
        {
            this.empno = empno;
            this.FullAnname = FullAnname;
            this.desc = desc;
            this.fromdate = fromdate;
            this.todate = todate;
            this.value = value;
       
        }
        public PremiumsDiscountsStaff(int empno, string FullAnname, string desc, DateTime fromdate,DateTime todate , decimal value)
        {
            this.empno = empno;
            this.FullAnname = FullAnname;
            this.desc = desc;
            this.fromdate = fromdate;
            this.todate = todate;
            this.value = value;

        }

    }
}
