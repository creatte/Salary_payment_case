using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeMailTransaction : AbstractTransactions.ChangeMethodTransaction
    {
        private string itsAddress;

        public ChangeMailTransaction(int empid, string address)
            : base(empid)
        {
            itsAddress = address;
        }

        public override Model.PaymentMethod GetMethod()
        {
            return new ModelImplementation.MailMethod(itsAddress);
        }
    }
}
