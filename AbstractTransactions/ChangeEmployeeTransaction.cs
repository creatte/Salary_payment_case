using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTransactions
{
    public abstract class ChangeEmployeeTransaction : TransactionApplication.Transaction
    {
        private int itsEmpid;

        public ChangeEmployeeTransaction(int empid)
        {
            itsEmpid = empid;
        }

        public void Execute()
        {
            Model.Employee e = DataBase.PayrollDatabase.Default.GetEmployee(itsEmpid);
            if (e != null)
                Change(e);
            else
                throw new Exception(DataBase.PayrollExceptionMessage.EmployeeNotExist);
        }

        public abstract void Change(Model.Employee e);

    }
}
