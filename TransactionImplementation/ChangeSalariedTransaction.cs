using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeSalariedTransaction : AbstractTransactions.ChangeClassificationTransaction
    {
        private double itsSalary;

        public ChangeSalariedTransaction(int empid, double salary)
            :base(empid)
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
