using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeHourlyTransaction : AbstractTransactions.ChangeClassificationTransaction
    {
        private double itsHourlyRate;

        public ChangeHourlyTransaction(int empid, double hourlyRate)
            :base(empid)
        {
            itsHourlyRate = hourlyRate;
        }

        public override Model.PaymentClassification GetClassification()
        {
            return new ModelImplementation.HourlyClassification(itsHourlyRate);
        }

        public override Model.PaymentSchedule GetSchedule()
        {
            return new ModelImplementation.WeeklySchedule();
        }
    }
}
