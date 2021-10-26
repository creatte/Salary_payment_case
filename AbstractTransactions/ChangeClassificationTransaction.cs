using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTransactions
{
    public abstract class ChangeClassificationTransaction:ChangeEmployeeTransaction
    {
        public ChangeClassificationTransaction(int empid)
            :base(empid)
        {
        }

        public override void Change(Model.Employee e)
        {
            Model.PaymentClassification pc = GetClassification();
            e.SetClassification(pc);

            Model.PaymentSchedule ps = GetSchedule();
            e.SetSchedule(ps);
        }

        public abstract Model.PaymentClassification GetClassification();
        public abstract Model.PaymentSchedule GetSchedule();
        
    }
}
