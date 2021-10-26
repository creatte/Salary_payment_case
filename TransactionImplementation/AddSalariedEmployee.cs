using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class AddSalariedEmployee : AbstractTransactions.AddEmployeeTransaction
    {
        private double itsSalary;

        public AddSalariedEmployee(int empid, string name, string address, double salary)
            : base(empid, name, address)
        {
            itsSalary = salary;
        }

        public override Model.PaymentClassification GetClassification()
        {
            return new ModelImplementation.SalariedClassification(itsSalary);
        }

        public override Model.PaymentSchedule GetSchedule()
        {
            return new ModelImplementation.MonthlySchedule();
        }
    }
}
