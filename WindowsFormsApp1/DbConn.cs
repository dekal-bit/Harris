using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DbConn
    {
        private string connString = "Server=database.corzy2n2ovnd.us-east-1.rds.amazonaws.com;User ID=admin;Password=Lukasz12;Database=Harris";

        public DataTable getAllPersonal()

        {
            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                DataTable personalContactDt = new DataTable();
                List<PersonalContact> personalContacts = new List<PersonalContact>();
                using (var cmd = new MySqlCommand("CALL selectAllPersonal();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())

                    {
                        personalContacts.Add(new PersonalContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFName = reader.GetString(1),
                            ContactLName = reader.GetString(2),
                            ContactAddress = reader.GetString(3),
                            ContactPostcode = reader.GetString(4),
                            ContactCity = reader.GetString(5),
                            ContactCompany = reader.GetString(6),
                            ContactEmail = reader.GetString(7),
                            ContactTel = reader.GetString(8),
                            PersonalHomeTel = reader.GetString(9),

                        });
                    }


                personalContactDt.Columns.Add("ContactID");
                personalContactDt.Columns.Add("ContactFName");
                personalContactDt.Columns.Add("ContactLName");
                personalContactDt.Columns.Add("ContactAddress");
                personalContactDt.Columns.Add("ContactPostcode");
                personalContactDt.Columns.Add("ContactCity");
                personalContactDt.Columns.Add("ContactCompany");
                personalContactDt.Columns.Add("ContactEmail");
                personalContactDt.Columns.Add("ContactTel");
                personalContactDt.Columns.Add("PersonalHomeTel");

                foreach (var item in personalContacts)
                {
                    var row = personalContactDt.NewRow();
                    row["ContactID"] = item.ContactID;
                    row["ContactFname"] = item.ContactFName;
                    row["ContactLName"] = item.ContactLName;
                    row["ContactAddress"] = item.ContactAddress;
                    row["ContactPostcode"] = item.ContactPostcode;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactCompany"] = item.ContactCompany;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactTel"] = item.ContactTel;
                    row["PersonalHomeTel"] = item.PersonalHomeTel;

                    personalContactDt.Rows.Add(row);

                }

                return personalContactDt;

            }

        }

        public void InsertPersonal(PersonalContact personalContact)
        {

            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactAddress);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactCompany);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p9", personalContact.PersonalHomeTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public void UpdatePersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactAddress);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactCompany);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p10", personalContact.PersonalHomeTel);
                    cmd.ExecuteNonQuery();
                }
            }

        }


        public void DeltePersonal(int id)
        {
            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL DeletePersonal (@p1);";
                    cmd.Parameters.AddWithValue("p1", id);

                    cmd.ExecuteNonQuery();
                }
            }

        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// 
        /// 
        /// 
        /// </summary>
        /// <returns></returns>

        public DataTable getAllBusiness()

        {
            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                DataTable businessDt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var cmd = new MySqlCommand("CALL selectAllBusiness();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())

                    {

                        businessContacts.Add(new BusinessContact
                        {
                            BusinessID = reader.GetInt32(0),
                            BusinessFName = reader.GetString(1),
                            BusinessOrder = reader.GetString(2),
                            BussinessAddress = reader.GetString(3),
                            BusinessPostcode = reader.GetString(4),
                            BusinessCity = reader.GetString(5),
                            ContactEmail = reader.GetString(6),
                            BusinessTel = reader.GetString(7),
                            BusinessHomeTel = reader.GetString(8),



                        });
                    }


                ////////////////////////////////////////////////////////////// Change the name of att to 

                businessDt.Columns.Add("BusinessID");
                businessDt.Columns.Add("BusinessFName");
                businessDt.Columns.Add("BusinessOrder");
                businessDt.Columns.Add("BussinessAddress");
                businessDt.Columns.Add("BusinessPostcode");
                businessDt.Columns.Add("BusinessCity");
                businessDt.Columns.Add("ContactEmail");
                businessDt.Columns.Add("BusinessTel");
                businessDt.Columns.Add("BusinessHomeTel");
              

                foreach (var item in businessContacts)
                {
                    var row = businessDt.NewRow();
                    row["BusinessID"] = item.BusinessID;
                    row["BusinessFName"] = item.BusinessFName;
                    row["BusinessOrder"] = item.BusinessOrder;
                    row["BussinessAddress"] = item.BussinessAddress;
                    row["BusinessPostcode"] = item.BusinessPostcode;
                    row["BusinessCity"] = item.BusinessCity;
                    row["ContactEmail"] = item.ContactEmail;
                    row["BusinessTel"] = item.BusinessTel;
                    row["BusinessHomeTel"] = item.BusinessHomeTel;
                  

                    businessDt.Rows.Add(row);

                }

                return businessDt;

            }




        }


        public void InsertBusiness(BusinessContact businessContact)
        {

            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL InsertBusiness (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);";
                    cmd.Parameters.AddWithValue("p1", businessContact.BusinessFName);
                    cmd.Parameters.AddWithValue("p2", businessContact.BusinessOrder);
                    cmd.Parameters.AddWithValue("p3", businessContact.BussinessAddress);
                    cmd.Parameters.AddWithValue("p4", businessContact.BusinessPostcode);
                    cmd.Parameters.AddWithValue("p5", businessContact.BusinessCity);
                    cmd.Parameters.AddWithValue("p6", businessContact.BusinessEmail);
                    cmd.Parameters.AddWithValue("p7", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p8", businessContact.BusinessHomeTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBusiness(BusinessContact businessContact)
        {

            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL UpdateBusiness (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.BusinessID);
                    cmd.Parameters.AddWithValue("p2", businessContact.BusinessFName);
                    cmd.Parameters.AddWithValue("p3", businessContact.BusinessOrder);
                    cmd.Parameters.AddWithValue("p4", businessContact.BussinessAddress);
                    cmd.Parameters.AddWithValue("p5", businessContact.BusinessPostcode);
                    cmd.Parameters.AddWithValue("p6", businessContact.BusinessCity);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p8", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p9", businessContact.BusinessHomeTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DelteBusiness(int id)
        {
            using (var conn = new MySqlConnection(connString))

            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL DeleteBusiness (@p1);";
                    cmd.Parameters.AddWithValue("p1", id);

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }


}































        


    













