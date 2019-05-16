using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BelalTransportGUI
{
    public class MedarbejderDB
    {
        private List<Medarbejeder> medarbejders = new List<Medarbejeder>();
        public void AddMedarbejder(Medarbejeder medarbejder)
        {
            medarbejders.Add(medarbejder);

        }
        public Medarbejeder GetMedarbejder(string CPR)
        {
            return medarbejders
        }

        private static string connectionString =
        "Data Source = EALSQL1.Eal.Local;" +
        "Database = C_DB06_2018;" +
        "User ID = C_STUDENT06;" +
        "Password = C_OPENDB06;";

        public void VisMedarbejder()
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
                                string CPR = reader["CPR"].ToString();
                                string MedarbejderFornavn = reader["Førstnavn"].ToString();
                                string MedarbejderEfternavn = reader["Efternavn"].ToString();

                                Medarbejeder medarbejeder = new Medarbejeder(CPR,MedarbejderFornavn,MedarbejderEfternavn);
                                
                                AddMedarbejder(medarbejeder);
                            }
                        }

                        con.Close();
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