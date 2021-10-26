using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeCommissionedTransaction : AbstractTransactions.ChangeClassificationTransaction
    {
        private double itsSalary;
        private double itsCommissionRate;

        public ChangeCommissionedTransaction(int empid, double salary, double commissionRate)
            : base(empid)
        {
            itsSalary = salary;
            itsCommissionRate = commissionRate;
        }

        public override Model.PaymentClassification GetClassification()
        {
            return new ModelImplementation.CommissionedClassification(itsSalary, itsCommissionRate);
        }

        public override Model.PaymentSchedule GetSchedule()
        {
            return new ModelImplementation.BiweeklySchedule();
        }
    }
}
