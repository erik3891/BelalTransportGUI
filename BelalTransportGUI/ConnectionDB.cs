using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static BelalTransportGUI.ConnectionDB;

namespace BelalTransportGUI
{
    public class ConnectionDB
    {
        //public static List<Employee> employees = new List<Employee>();
        public static List<string> MyList = new List<string>();

        public void addmylist()
        {
            MyList.Add("mor");
            MyList.Add("Far");
        }
        //public void AddEmployee(Employee employee)
        //{
        //    employees.Add(employee);

        //}
        
        //public List<Employee> GetEmployees()
        //{
        //    return employees;
        //}
        //public Match GetMatch(string teamName1, string teamName2)
        //{
        //    Match getMatch = matches[0];
        //    for (int i = 0; i < matches.Count; i++)
        //    {
        //        if (teamName1 == matches[i].FirstOpponent.ToString() &&
        //            teamName2 == matches[i].SecondOpponent.ToString())
        //        {
        //            getMatch = matches[i];
        //        }
        //    }
        //    return getMatch;
        //}

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
                                //string fullemployee = CPR + ":" + EmployeeFirstname + " " + EmployeeLastName;
                                //string fullemployee = "mor";
                                Employee e = new Employee(CPR + ":" + EmployeeFirstname + " " + EmployeeLastName);

                                //AddEmployee(e);

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
