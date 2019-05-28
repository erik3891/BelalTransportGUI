using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BelalTransportGUI
{
    public class ConnectionEmployee
    {
        private List<Employee> employees = new List<Employee>();
        private List<EmployeePaycheck> employeepaychecks = new List<EmployeePaycheck>();

        public void AddEmployeePaycheck(EmployeePaycheck employeePaycheck)
        {
            employeepaychecks.Add(employeePaycheck);
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);

        }


        public Employee GetEmployeeName(string employeedata)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeData == employeedata)
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

        
        public void GetAllEmployees()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * Belal_tab_Worker";
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
                                string EmployeeFirstname = reader["Firstname"].ToString();
                                string EmployeeLastName = reader["Lastname"].ToString();

                                string EmployeeData = EmployeeFirstname + EmployeeLastName;
                                Employee employee = new Employee(EmployeeData);

                                AddEmployee(employee);
                            }
                        }

                        con.Close();
                    }
                    catch (Exception e)
                    {
                       Console.WriteLine(e.Message);
                    }
                }
            }
        }
        public void GetEmployeeeDeduction()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * Belal_tab_Worker";
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
                                string EmployeeFirstname = reader["Firstname"].ToString();
                                string EmployeeLastName = reader["Lastname"].ToString();
                                string Deduction = reader["Deduction"].ToString();

                                
                                EmployeePaycheck employeePaycheck = new EmployeePaycheck(CPR, EmployeeFirstname, EmployeeLastName, Deduction);
                                AddEmployeePaycheck(employeePaycheck);

                                

                            }
                        }

                        con.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
