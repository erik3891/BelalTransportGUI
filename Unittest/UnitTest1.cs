using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelalTransportGUI;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        Employee e1, e2, e3;
        ConnectionDB connection;

        [TestInitialize]
        public void Init()
        {
            connection = new ConnectionDB();
            e1 = new Employee("Erik Hansen");
            e2 = new Employee("Phillip Bonné");
            e3 = new Employee("Ahmad Youssef");
            connection.AddEmployee(e1);
            connection.AddEmployee(e2);
            connection.AddEmployee(e3);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Erik Hansen", connection.GetEmployeesname(e1.EmployeeData).EmployeeData);
            Assert.AreEqual("Phillip Bonné", connection.GetEmployeesname(e2.EmployeeData).EmployeeData);
            Assert.AreEqual("Ahmad Youssef", connection.GetEmployeesname(e3.EmployeeData).EmployeeData);
        }
    }
}
