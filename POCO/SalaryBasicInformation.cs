using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class SalaryBasicInformation
    {

        public int empno { get; set; }
        public string FullAnname { get; set; }
        public decimal saljd { get; set; }
        public decimal socialj { get; set; }
        public decimal tax_pass_value { get; set; }
        public decimal emptax { get; set; }
        public decimal wifetax { get; set; }
        public int month_count { get; set; }
      
        public SalaryBasicInformation()
        {
            this.empno = empno;
            this.FullAnname = FullAnname;
            this.saljd = saljd;
            this.socialj = socialj;
            this.tax_pass_value = tax_pass_value;
            this.emptax = emptax;
            this.wifetax = wifetax;
            this.month_count = month_count;
        }
        public SalaryBasicInformation(int empno, string FullAnname, decimal saljd, decimal socialj, decimal tax_pass_value, decimal emptax, decimal wifetax ,int month_count)
        {
            this.empno = empno;
            this.FullAnname = FullAnname;
            this.saljd = saljd;
            this.socialj = socialj;
            this.tax_pass_value = tax_pass_value;
            this.emptax = emptax;
            this.wifetax = wifetax;
            this.month_count = month_count;
        }

    }
}
