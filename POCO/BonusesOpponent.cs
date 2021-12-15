using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class BonusesOpponent
    {

        public int id  { get; set; }
        public string desc  { get; set; }
        public decimal value { get; set; }
        public int disable  { get; set; }

        public BonusesOpponent()
        {
            this.id = id;
            this.desc = desc;
            this.value = value;
            this.disable = disable;
        }
        public BonusesOpponent( int id, string desc, decimal value, int disable)
        {

            this.id = id;
            this.desc = desc;
            this.value = value;
            this.disable = disable;
        }

    }
}
