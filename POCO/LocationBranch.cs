using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class LocationBranch
    {
        public int id  { get; set; }
        public string Name  { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string note { get; set; }
        public int MangerId { get; set; }
        public int SupervisorId1 { get; set; }
        public int SupervisorId2 { get; set; }
        public int Disable  { get; set; }
        public LocationBranch()
        {
            this.id = id;
            this.Name = Name;
            this.Phone = Phone;
            this.Fax = Fax;
            this.Country = Country;
            this.City = City;
            this.Address = Address;
            this.note = note;
            this.MangerId = MangerId;
            this.SupervisorId1 = SupervisorId1;
            this.SupervisorId2 = SupervisorId2;
            this.Disable = Disable;
        }
        public LocationBranch(int id, string Name, string Phone, string Fax,string Country,string City,string Address,string note,int MangerId, int SupervisorId1, int SupervisorId2,  int Disable)
        {
            this.id = id;
            this.Name = Name;
            this.Phone = Phone;
            this.Fax = Fax;
            this.Country = Country;
            this.City = City;
            this.Address = Address;
            this.note = note;
            this.MangerId = MangerId;
            this.SupervisorId1 = SupervisorId1;
            this.SupervisorId2 = SupervisorId2;
            this.Disable = Disable;
        }

    }
}
