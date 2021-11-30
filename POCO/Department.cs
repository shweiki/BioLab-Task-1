using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class Department
    {
        public int RC  { get; set; }
        public int companyID { get; set; }
        public int id  { get; set; }
        public string departmentname  { get; set; }
        public string notess { get; set; }
        public int disable  { get; set; }

        public Department()
        {
            this.RC = RC;
            this.companyID = companyID;
            this.id = id;
            this.departmentname = departmentname;
            this.notess = notess;
            this.disable = disable;
        }
        public Department(int RC, int companyID, int id, string departmentname, string notess, int disable)
        {
            this.RC = RC;
            this.companyID = companyID;
            this.id = id;
            this.departmentname = departmentname;
            this.notess = notess;
            this.disable = disable;
        }

    }
}
