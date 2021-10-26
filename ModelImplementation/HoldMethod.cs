using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class HoldMethod : Model.PaymentMethod
    {
        #region PaymentMethod Members

        public void Pay(Model.Paycheck pc)
        {
            pc.SetField("Disposition", "Hold");
        }

        #endregion
    }
}
