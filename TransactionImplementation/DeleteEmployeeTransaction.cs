using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class DeleteEmployeeTransaction : TransactionApplication.Transaction
    {
        private int itsEmpid;

        public DeleteEmployeeTransaction(int empid)
        {
            itsEmpid = empid;
        }

        public void Execute()
        {
            DataBase.PayrollDatabase.Default.DeleteEmployee(itsEmpid);
        }

    }
}
