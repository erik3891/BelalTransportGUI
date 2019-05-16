using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BelalTransportGUI
{
    class ConnectionDB
    {
        private static string connectionString =
        "Data Source = EALSQL1.Eal.Local;" +
        "Database = C_DB06_2018;" +
        "User ID = C_STUDENT06;" +
        "Password = C_OPENDB06;";

        public void ShowEmployee()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * Belal_tab_Medarbejeder";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int PetID = int.Parse(reader["PetID"].ToString());
                                string PetName = reader["PetName"].ToString();
                                string PetType = reader["PetType"].ToString();
                                string PetBreed = reader["PetBreed"].ToString();
                                string PetDOBl = reader["PetDOBl"].ToString();
                                string petWeight = reader["petWeight"].ToString();
                                int OwnerID = int.Parse(reader["OwnerID"].ToString());
                                Console.WriteLine(PetID + ", " + PetName + ", " + PetType + ", " + PetBreed + ", " + PetDOBl + ", " + petWeight + ", " + OwnerID);
                            }
                        }

                        con.Close();

                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
