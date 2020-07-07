using System;
using System.Collections.Generic;
using System.Text;
using ExcelDataReader;
using System.IO;
using System.Data;
using System.Xml.Serialization;
using System.Linq;
using System.Net;


namespace ADD_DB_My_Apteka
{
    public class Apt_to_DB
    {
        string APTFile = @"C:\C#\ADD_DB_My_Apteka\apt_to_db.xlsx";
        internal List<Apt> GetApts()
        {
            List<Apt> data_apt = new List<Apt>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(APTFile, FileMode.Open,FileAccess.Read))
            {

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet().Tables[0];
                    foreach(DataRow row in result.Rows)
                        if(!string.IsNullOrEmpty(row[26].ToString()))
                        {
                            
                            Apt apt = new Apt();
                            apt.ID = string.IsNullOrEmpty(row[0].ToString()) ? 0 : int.Parse(row[0].ToString());
                            apt.flag = string.IsNullOrEmpty(row[1].ToString()) ? 0 : int.Parse(row[1].ToString());
                            apt.Node = string.IsNullOrEmpty(row[2].ToString()) ? 0 : int.Parse(row[2].ToString());
                            apt.UR = string.IsNullOrEmpty(row[3].ToString()) ? null : row[3].ToString();
                            apt.INN = string.IsNullOrEmpty(row[4].ToString()) ? null : row[4].ToString();
                            apt.Address = string.IsNullOrEmpty(row[5].ToString())? null : row[5].ToString();
                            apt.Telephone = string.IsNullOrEmpty(row[6].ToString()) ? null : row[6].ToString();
                            apt.Email = string.IsNullOrEmpty(row[7].ToString()) ? null : row[7].ToString();
                            apt.Pass_Email = string.IsNullOrEmpty(row[8].ToString()) ? null : row[8].ToString();
                            apt.Work_time = string.IsNullOrEmpty(row[9].ToString()) ? null : row[9].ToString();
                            apt.Kass_1 = string.IsNullOrEmpty(row[10].ToString()) ? null : row[10].ToString();
                            apt.Kass1_RN = string.IsNullOrEmpty(row[11].ToString()) ? null : row[11].ToString();
                            apt.Kass1_ZN = string.IsNullOrEmpty(row[12].ToString()) ? null : row[12].ToString();
                            apt.Kass1_FN = string.IsNullOrEmpty(row[13].ToString()) ? null : row[13].ToString();
                            apt.Kass_2 = string.IsNullOrEmpty(row[14].ToString()) ? null : row[14].ToString();
                            apt.Kass2_RN = string.IsNullOrEmpty(row[15].ToString())? null : row[15].ToString();
                            apt.Kass2_ZN= string.IsNullOrEmpty(row[16].ToString()) ? null : row[16].ToString();
                            apt.Kass2_FN = string.IsNullOrEmpty(row[17].ToString()) ? null : row[17].ToString();
                            apt.Kass_3 = string.IsNullOrEmpty(row[18].ToString()) ? null : row[18].ToString();
                            apt.Kass3_RN = string.IsNullOrEmpty(row[19].ToString()) ? null : row[19].ToString();
                            apt.Kass3_ZN = string.IsNullOrEmpty(row[20].ToString()) ? null : row[20].ToString();
                            apt.Kass3_FN = string.IsNullOrEmpty(row[21].ToString()) ? null : row[21].ToString() ;
                            apt.Kass_4 = string.IsNullOrEmpty(row[22].ToString()) ? null : row[22].ToString();
                            apt.Kass4_RN = string.IsNullOrEmpty(row[23].ToString()) ? null : row[23].ToString();
                            apt.Kass4_ZN = string.IsNullOrEmpty(row[24].ToString()) ? null : row[24].ToString();
                            apt.Kass4_FN = string.IsNullOrEmpty(row[25].ToString()) ? null : row[25].ToString();
                            apt.VPN = string.IsNullOrEmpty(row[26].ToString()) ? null : row[26].ToString();
                            apt.VPN_CODE = string.IsNullOrEmpty(row[27].ToString()) ? null : row[27].ToString();
                            apt.Operator = string.IsNullOrEmpty(row[28].ToString()) ? null : row[28].ToString();
                            apt.Tel_Operator = string.IsNullOrEmpty(row[29].ToString()) ? null : row[29].ToString();

                            data_apt.Add(apt);
                        }
                    return data_apt;
                }
            }
        }
    }
}
