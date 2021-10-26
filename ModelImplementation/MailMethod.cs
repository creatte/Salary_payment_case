using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class MailMethod : Model.PaymentMethod
    {
        private string itsAddress;

        public MailMethod(string address)
        {
            itsAddress = address;
        }

        public string GetAddress()
        {
            return itsAddress;
        }

        #region PaymentMethod Members

        public void Pay(Model.Paycheck pc)
        {
            pc.SetField("Disposition", "Mail");
        }

        #endregion
    }
}
