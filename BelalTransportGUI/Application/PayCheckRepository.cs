using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI.Application
{
    class PayCheckRepository
    {
        private List<PayCheck> paychecks = new List<PayCheck>();

        public void AddPaycheck(PayCheck paycheck)
        {
            paychecks.Add(paycheck);
        }
        private static string connectionString =
        "Data Source = EALSQL1.Eal.Local;" +
        "Database = C_DB06_2018;" +
        "User ID = C_STUDENT06;" +
        "Password = C_OPENDB06;";


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


                                PayCheck paycheck = new PayCheck(CPR, EmployeeFirstname, EmployeeLastName, Deduction);
                                AddPaycheck(paycheck);



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
