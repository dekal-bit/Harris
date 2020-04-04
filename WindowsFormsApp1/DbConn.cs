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
       

          
        public void UpdatePersonal (PersonalContact personalContact)
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
    }
    
}


    
