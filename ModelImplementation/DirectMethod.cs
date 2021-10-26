using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class DirectMethod : Model.PaymentMethod
    {
        private string itsBank;
        private string itsAccount;

        public DirectMethod(string bank, string account)
        {
            itsBank = bank;
            itsAccount = account;
        }

        public string GetBank()
        {
            return itsBank;
        }

        public string GetAccount()
        {
            return itsAccount;
        }

        #region PaymentMethod Members

        public void Pay(Model.Paycheck pc)
        {
            pc.SetField("Disposition", "Direct");
        }

        #endregion
    }
}
