using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class StaffBasicInformation
    {

        public int empno { get; set; }
        public int companyID { get; set; }
        public string FullEnname { get; set; }
        public string FullAnname { get; set; }
        public string FArname { get; set; }
        public string SArname { get; set; }
        public string TArname { get; set; }
        public string LArname { get; set; }
        public string FEnname { get; set; }
        public string SEnname { get; set; }
        public string TEnname { get; set; }
        public string LEnname { get; set; }
        public DateTime Dateofbirth { get; set; }
        public int Nationality { get; set; }
        public int Religion { get; set; }
        public string NationalNo { get; set; }
        public int gender { get; set; }
        public int maritalstatus { get; set; }
        public int childcount { get; set; }
        public string passportno { get; set; }
        public string socialno { get; set; }
        public int Country { get; set; }
        public string City { get; set; }
        public string Streetname { get; set; }
        public string PostalCode { get; set; }
        public string PoBox { get; set; }
        public string PersonalEmail { get; set; }
        public string workEmail { get; set; }
        public string Homephone { get; set; }
        public string Mobilephone { get; set; }
        public int branchno { get; set; }
        public int departmentno { get; set; }
        public int postionno { get; set; }
        public DateTime dateemployement { get; set; }
        public DateTime dateinstalltion { get; set; }
        public decimal vactionday { get; set; }
        public decimal sickday { get; set; }
        public int EmployeeStatus { get; set; }
        public int SocialSecured { get; set; }
        public int Insured { get; set; }
        public int EligibleForOvertime { get; set; }
        public int ResolveDelay { get; set; }
        public int defaultWorkshift { get; set; }
        public int workhours { get; set; }
        public int Resignation { get; set; }
        public DateTime lastday { get; set; }
        public int weekendcount { get; set; }
        public int Seriouscareer { get; set; }
        public int deleted { get; set; }
        public int Hide { get; set; }
        public int chkout { get; set; }
        public string attachmentPic { get; set; }

        public StaffBasicInformation()
        {
            this.empno = empno;
            this.companyID = companyID;
            this.FullEnname = FullEnname;
            this.FullAnname = FullAnname;
            this.FArname = FArname;
            this.SArname = SArname;
            this.TArname = TArname;
            this.LArname = LArname;
            this.FEnname = FEnname;
            this.SEnname = SEnname;
            this.TEnname = TEnname;
            this.LEnname = LEnname;
            this.Dateofbirth = Dateofbirth;
            this.Nationality = Nationality;
            this.Religion = Religion;
            this.NationalNo = NationalNo;
            this.gender = gender;
            this.maritalstatus = maritalstatus;
            this.childcount = childcount;
            this.passportno = passportno;
            this.socialno = socialno;
            this.Country = Country;
            this.City = City;
            this.Streetname = Streetname;
            this.PostalCode = PostalCode;
            this.PoBox = PoBox;
            this.PersonalEmail = PersonalEmail;
            this.workEmail = workEmail;
            this.Homephone = Homephone;
            this.Mobilephone = Mobilephone;
            this.branchno = branchno;
            this.departmentno = departmentno;
            this.postionno = postionno;
            this.dateemployement = dateemployement;
            this.dateinstalltion = dateinstalltion;
            this.vactionday = vactionday;
            this.sickday = sickday;
            this.EmployeeStatus = EmployeeStatus;
            this.SocialSecured = SocialSecured;
            this.Insured = Insured;
            this.EligibleForOvertime = EligibleForOvertime;
            this.ResolveDelay = ResolveDelay;
            this.defaultWorkshift = defaultWorkshift;
            this.workhours = workhours;
            this.Resignation = Resignation;
            this.lastday = lastday;
            this.weekendcount = weekendcount;
            this.Seriouscareer = Seriouscareer;
            this.deleted = deleted;
            this.Hide = Hide;
            this.chkout = chkout;
            this.attachmentPic = attachmentPic;
        }

        public StaffBasicInformation(int empno,
         int companyID,
         string FullEnname,
         string FullAnname,
         string FArname,
         string SArname,
         string TArname,
         string LArname,
         string FEnname,
         string SEnname,
         string TEnname,
         string LEnname,
         DateTime Dateofbirth,
         int Nationality,
         int Religion,
         string NationalNo,
         int gender,
         int maritalstatus,
         int childcount,
         string passportno,
         string socialno,
         int Country,
         string City,
         string Streetname,
         string PostalCode,
         string PoBox,
         string PersonalEmail,
         string workEmail,
         string Homephone,
         string Mobilephone,
         int branchno,
         int departmentno,
         int postionno,
         DateTime dateemployement,
         DateTime dateinstalltion,
         decimal vactionday,
         decimal sickday,
         int EmployeeStatus,
         int SocialSecured,
         int Insured,
         int EligibleForOvertime,
         int ResolveDelay,
         int defaultWorkshift,
         int workhours,
         int Resignation,
         DateTime lastday,
         int weekendcount,
         int Seriouscareer,
         int deleted,
         int Hide,
         int chkout,
         string attachmentPic)
        {
            this.empno = empno;
            this.companyID = companyID;
            this.FullEnname = FullEnname;
            this.FullAnname = FullAnname;
            this.FArname = FArname;
            this.SArname = SArname;
            this.TArname = TArname;
            this.LArname = LArname;
            this.FEnname = FEnname;
            this.SEnname = SEnname;
            this.TEnname = TEnname;
            this.LEnname = LEnname;
            this.Dateofbirth = Dateofbirth;
            this.Nationality = Nationality;
            this.Religion = Religion;
            this.NationalNo = NationalNo;
            this.gender = gender;
            this.maritalstatus = maritalstatus;
            this.childcount = childcount;
            this.passportno = passportno;
            this.socialno = socialno;
            this.Country = Country;
            this.City = City;
            this.Streetname = Streetname;
            this.PostalCode = PostalCode;
            this.PoBox = PoBox;
            this.PersonalEmail = PersonalEmail;
            this.workEmail = workEmail;
            this.Homephone = Homephone;
            this.Mobilephone = Mobilephone;
            this.branchno = branchno;
            this.departmentno = departmentno;
            this.postionno = postionno;
            this.dateemployement = dateemployement;
            this.dateinstalltion = dateinstalltion;
            this.vactionday = vactionday;
            this.sickday = sickday;
            this.EmployeeStatus = EmployeeStatus;
            this.SocialSecured = SocialSecured;
            this.Insured = Insured;
            this.EligibleForOvertime = EligibleForOvertime;
            this.ResolveDelay = ResolveDelay;
            this.defaultWorkshift = defaultWorkshift;
            this.workhours = workhours;
            this.Resignation = Resignation;
            this.lastday = lastday;
            this.weekendcount = weekendcount;
            this.Seriouscareer = Seriouscareer;
            this.deleted = deleted;
            this.Hide = Hide;
            this.chkout = chkout;
            this.attachmentPic = attachmentPic;
        }

    }
}
