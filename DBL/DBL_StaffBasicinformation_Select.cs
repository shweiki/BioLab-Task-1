using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
namespace DBL
{
    public class DBL_StaffBasicinformation_Select
    {
        #region Test 2
        public List<POCO.StaffBasicInformation> GetData(int? empno, int? empno2,string empname)
        {
            DAL_StaffBasicinformation_P oclass1DAL = new DAL_StaffBasicinformation_P();
            DataSet DS = oclass1DAL.Get(empno,  empno2,  empname);

            //link 

           List<POCO.StaffBasicInformation> LAttribute = new List<POCO.StaffBasicInformation>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add (new POCO.StaffBasicInformation(
                        (!(currentRow["empno"] is DBNull)) ? Convert.ToInt32(currentRow["empno"]) : 0,
                        (!(currentRow["companyID"] is DBNull)) ? Convert.ToInt32(currentRow["companyID"]) : 0,
                        (!(currentRow["FullEnname"] is DBNull)) ? currentRow["FullEnname"].ToString() : null,
                        (!(currentRow["FullAnname"] is DBNull)) ? currentRow["FullAnname"].ToString() : null,
                        (!(currentRow["FArname"] is DBNull)) ? currentRow["FArname"].ToString() : null,
                        (!(currentRow["SArname"] is DBNull)) ? currentRow["SArname"].ToString() : null,
                        (!(currentRow["TArname"] is DBNull)) ? currentRow["TArname"].ToString() : null,
                        (!(currentRow["LArname"] is DBNull)) ? currentRow["LArname"].ToString() : null,
                        (!(currentRow["FEnname"] is DBNull)) ? currentRow["FEnname"].ToString() : null,
                        (!(currentRow["SEnname"] is DBNull)) ? currentRow["SEnname"].ToString() : null,
                        (!(currentRow["TEnname"] is DBNull)) ? currentRow["TEnname"].ToString() : null,
                        (!(currentRow["LEnname"] is DBNull)) ? currentRow["LEnname"].ToString() : null,
                        (!(currentRow["Dateofbirth"] is DBNull)) ? Convert.ToDateTime(currentRow["Dateofbirth"]) : new DateTime(),
                        (!(currentRow["Nationality"] is DBNull)) ? Convert.ToInt32(currentRow["Nationality"]) : 0,
                        (!(currentRow["Religion"] is DBNull)) ? Convert.ToInt32(currentRow["Religion"]) : 0,
                        currentRow["NationalNo"].ToString(),
                        (!(currentRow["gender"] is DBNull)) ? Convert.ToInt32(currentRow["gender"]) : 0,
                        (!(currentRow["maritalstatus"] is DBNull)) ? Convert.ToInt32(currentRow["maritalstatus"]) : 0,
                        (!(currentRow["childcount"] is DBNull)) ? Convert.ToInt32(currentRow["childcount"]) : 0,
                        currentRow["passportno"].ToString(),
                        currentRow["socialno"].ToString(),
                        (!(currentRow["Country"] is DBNull)) ? Convert.ToInt32(currentRow["Country"]) : 0,
                        currentRow["City"].ToString(),
                        currentRow["Streetname"].ToString(),
                        currentRow["PostalCode"].ToString(),
                        currentRow["PoBox"].ToString(),
                        currentRow["PersonalEmail"].ToString(),
                        currentRow["workEmail"].ToString(),
                        currentRow["Homephone"].ToString(),
                        currentRow["Mobilephone"].ToString(),
                        (!(currentRow["branchno"] is DBNull)) ? Convert.ToInt32(currentRow["branchno"]) : 0,
                        (!(currentRow["departmentno"] is DBNull)) ? Convert.ToInt32(currentRow["departmentno"]) : 0,
                        (!(currentRow["postionno"] is DBNull)) ? Convert.ToInt32(currentRow["postionno"]) : 0,
                        (!(currentRow["dateemployement"] is DBNull)) ? Convert.ToDateTime(currentRow["dateemployement"]) : new DateTime(),
                        (!(currentRow["dateinstalltion"] is DBNull)) ? Convert.ToDateTime(currentRow["dateinstalltion"]) : new DateTime(),
                        (!(currentRow["vactionday"] is DBNull)) ? Convert.ToDecimal(currentRow["vactionday"]) : 0,
                        (!(currentRow["sickday"] is DBNull)) ? Convert.ToDecimal(currentRow["sickday"]) : 0,
                        (!(currentRow["EmployeeStatus"] is DBNull)) ? Convert.ToInt32(currentRow["EmployeeStatus"]) : 0,
                        (!(currentRow["SocialSecured"] is DBNull)) ? Convert.ToInt32(currentRow["SocialSecured"]) : 0,
                        (!(currentRow["Insured"] is DBNull)) ? Convert.ToInt32(currentRow["Insured"]) : 0,
                        (!(currentRow["EligibleForOvertime"] is DBNull)) ? Convert.ToInt32(currentRow["EligibleForOvertime"]) : 0,
                        (!(currentRow["ResolveDelay"] is DBNull)) ? Convert.ToInt32(currentRow["ResolveDelay"]) : 0,
                        (!(currentRow["defaultWorkshift"] is DBNull)) ? Convert.ToInt32(currentRow["defaultWorkshift"]) : 0,
                        (!(currentRow["workhours"] is DBNull)) ? Convert.ToInt32(currentRow["workhours"]) : 0,
                        (!(currentRow["Resignation"] is DBNull)) ? Convert.ToInt32(currentRow["Resignation"]) : 0,
                        (!(currentRow["lastday"] is DBNull)) ? Convert.ToDateTime(currentRow["lastday"]) : new DateTime(),
                        (!(currentRow["weekendcount"] is DBNull)) ? Convert.ToInt32(currentRow["weekendcount"]) : 0,
                        (!(currentRow["Seriouscareer"] is DBNull)) ? Convert.ToInt32(currentRow["Seriouscareer"]) : 0,
                        (!(currentRow["deleted"] is DBNull)) ? Convert.ToInt32(currentRow["deleted"]) : 0,
                        (!(currentRow["Hide"] is DBNull)) ? Convert.ToInt32(currentRow["Hide"]) : 0,
                        (!(currentRow["chkout"] is DBNull)) ? Convert.ToInt32(currentRow["chkout"]) : 0,
                        currentRow["attachmentPic"].ToString()
                        ));
                    }
                }
            }
            return LAttribute;

        }

        #endregion


    }
}
