using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTransactions
{
    public abstract class AddEmployeeTransaction : TransactionApplication.Transaction
    {
        private int itsEmpid;
        private string itsName, itsAddress;

        public AddEmployeeTransaction(int empid, string name, string address)
        {
            itsEmpid = empid;
            itsName = name;
            itsAddress = address;
        }

        public abstract Model.PaymentClassification GetClassification();

        public abstract Model.PaymentSchedule GetSchedule();

        public virtual void Execute()
        {
            Model.PaymentClassification pc = GetClassification();
            Model.PaymentSchedule ps = GetSchedule();
            Model.PaymentMethod pm = new ModelImplementation.HoldMethod();
            Model.Employee e = new Model.Employee(itsEmpid, itsName, itsAddress);
            e.SetClassification(pc);
            e.SetSchedule(ps);
            e.SetMethod(pm);
            DataBase.PayrollDatabase.Default.AddEmployee(itsEmpid, e);


        }
    }
}
