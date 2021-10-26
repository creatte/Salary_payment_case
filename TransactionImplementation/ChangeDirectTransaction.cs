using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeDirectTransaction : AbstractTransactions.ChangeMethodTransaction
    {
        private string itsBank;
        private string itsAccount;

        public ChangeDirectTransaction(int empid,string bank,string account)
            :base(empid)
        {
            itsBank = bank;
            itsAccount = account;
        }

        public override Model.PaymentMethod GetMethod()
        {
            return new ModelImplementation.DirectMethod(itsBank, itsAccount);
        }
    }
}
