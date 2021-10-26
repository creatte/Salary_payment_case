using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class AddHourlyEmployee : AbstractTransactions.AddEmployeeTransaction
    {
        private double itsHourlyRate;
        
        public AddHourlyEmployee(int empid, string name, string address, double hourlyRate)
            :base(empid,name,address)
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
