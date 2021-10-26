using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeHoldTransaction : AbstractTransactions.ChangeMethodTransaction
    {
        public ChangeHoldTransaction(int empid)
            :base(empid)
        {
        }

        public override Model.PaymentMethod GetMethod()
        {
            return new ModelImplementation.HoldMethod();
        }
    }
}
