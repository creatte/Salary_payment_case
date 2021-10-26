using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class AddCommissionedEmployee : AbstractTransactions.AddEmployeeTransaction
    {
        private double itsSalary;
        private double itsCommissionRate;

        public AddCommissionedEmployee(int empid, string name, string address, double salary, double commissionRate)
            : base(empid, name, address)
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
