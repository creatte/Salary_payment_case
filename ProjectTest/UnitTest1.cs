using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectTest
{
    [TestClass]
    public class UnitTest1
    {
                
        [TestInitialize()]
        public void TestInitialize()
        {
            DataBase.PayrollDatabase.Default.clear();
        }

        [Description("增加一个带薪雇员"), TestMethod]
        public void TestAddSalariedEmployee()
        {
            int empid = 1;
            TransactionImplementation.AddSalariedEmployee t = (TransactionImplementation.AddSalariedEmployee)TransactionFactory.TransactionFactory.CreateModelIM("AddSalariedEmployee");
            
          
        }
    }
}
