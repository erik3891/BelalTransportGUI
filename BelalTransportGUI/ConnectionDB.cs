using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BelalTransportGUI
{
    public class ConnectionDB
    {
        private static List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);

        }
        public static Employee GetEmployee(string cpr)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].CPR == cpr)
                {
                    return employees[i];
                }
            }
            return null;
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
                                string EmployeeFirstname = reader["Førstnavn"].ToString();
                                string EmployeeLastName = reader["Efternavn"].ToString();

                                Employee employee = new Employee(CPR, EmployeeFirstname, EmployeeLastName);

                                AddEmployee(employee);
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
