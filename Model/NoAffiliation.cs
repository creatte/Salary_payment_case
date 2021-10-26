using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class NoAffiliation:Affiliation
    {

        #region Affiliation Members

        public double CalculateDeductions(Paycheck pc)
        {
            return 0;
        }

        #endregion

    }
}
