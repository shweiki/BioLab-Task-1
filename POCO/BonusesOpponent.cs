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
        public string descc { get; set; }
        public int flag { get; set; }
        public int social { get; set; }
        public int tax { get; set; }
        public string notes { get; set; }
    
        public BonusesOpponent()
        {
            this.id = id;
            this.descc = descc;
            this.flag = flag;
            this.social = social;
            this.tax = tax;
            this.notes = notes;
        }
        public BonusesOpponent( int id, string descc, int flag, int social,int tax , string notes)
        {

            this.id = id;
            this.descc = descc;
            this.flag = flag;
            this.social = social;
            this.tax = tax;
            this.notes = notes;
        }

    }
}
