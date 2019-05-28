using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelalTransportGUI;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        Employee e1, e2, e3;
        ConnectionEmployee connection;

        [TestInitialize]
        public void Init()
        {
            connection = new ConnectionEmployee();
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
            Assert.AreEqual("Erik Hansen", connection.GetEmployeeName(e1.EmployeeData).EmployeeData);
            Assert.AreEqual("Phillip Bonné", connection.GetEmployeeName(e2.EmployeeData).EmployeeData);
            Assert.AreEqual("Ahmad Youssef", connection.GetEmployeeName(e3.EmployeeData).EmployeeData);
        }
    }
}
