﻿using System;
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
        private List<Employee> medarbejders = new List<Employee>();
        public void AddEmployee(Employee medarbejder)
        {
            medarbejders.Add(medarbejder);

        }
        public Employee GetEmployee(string CPR)
        {
            return medarbejders;
        }

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
                                string CPR = reader["CPR"].ToString();
                                string MedarbejderFornavn = reader["Førstnavn"].ToString();
                                string MedarbejderEfternavn = reader["Efternavn"].ToString();

                                Employee medarbejeder = new Employee(CPR, MedarbejderFornavn, MedarbejderEfternavn);

                                AddEmployee(medarbejeder);
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
