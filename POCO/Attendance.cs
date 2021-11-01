using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class Attendance
    {
        public Attendance()
        {
            this.id_auto = null;
            this.idout = null;
            this.days = "";
            this.checkdate = DateTime.Now;
            this.checkToDate = DateTime.Now;
            this.checkin = null;
            this.checkout = null;
            this.BranchId = null;
            this.FK_EmpNo = null;
            Shift = "";
            DiffIn = "";
            DiffOut = "";
        }
        //To Fill Data
        public Attendance(int? id_auto, int idout, int? USERID, string EmpName, string days, DateTime checkdate, string checkin, string checkout, string shift, string diffIn, string diffOut)
        {
            this.id_auto = id_auto;
            this.idout = idout;
            this.FK_EmpNo = USERID;
            this.EmpName = EmpName;
            this.days = days;
            this.checkdate = checkdate;
            this.checkin = checkin;
            this.checkout = checkout;
            Shift = shift;
            DiffIn = diffIn;
            DiffOut = diffOut;
        }
        //ToEdit Or delete Values
        public Attendance(int id_auto, string checkin, int idout, string checkout, int? Type)
        {
            this.id_auto = id_auto;
            this.checkin = checkin;

            this.idout = idout;
            this.checkout = checkout;
            this.Type = Type;
        }

        public int? id_auto { get; set; }  //Id checkIn
        public int? idout { get; set; }  //Id CheckOut
        public int? FK_EmpNo { get; set; }
        public string EmpName { get; set; }

        public string days { get; set; }
        public DateTime checkdate { get; set; }

        public string checkin { get; set; }
        public string checkout { get; set; }

        public string Shift { get; set; }

        public string DiffIn { get; set; }
        public string DiffOut { get; set; }

        /// <summary>
        /// Using To get Search Value admin
        /// </summary>
        public DateTime checkToDate { get; set; }
        public int? BranchId { get; set; }
        public int? Type { get; set; }

    }
}
