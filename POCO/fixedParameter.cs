using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class fixedParameter
    {
        public int id { get; set; }
        public decimal Hourovertime { get; set; }
        public decimal highestsalary { get; set; }
        public decimal expmarroed { get; set; }
        public decimal socialper { get; set; }
        public decimal expsingle { get; set; }
        public fixedParameter()
        {
            this.id = id;
            this.Hourovertime = Hourovertime;
            this.highestsalary = highestsalary;
            this.expmarroed = expmarroed;
            this.socialper = socialper;
            this.expsingle = expsingle;
        }
        public fixedParameter(int id, decimal Hourovertime, decimal highestsalary, decimal expmarroed, decimal socialper, decimal expsingle)
        {
            this.id = id;
            this.Hourovertime = Hourovertime;
            this.highestsalary = highestsalary;
            this.expmarroed = expmarroed;
            this.socialper = socialper;
            this.expsingle = expsingle;
        }

    }
}
