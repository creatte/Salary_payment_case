using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTransactions
{
    public abstract class ChangeAffiliationTransaction : ChangeEmployeeTransaction, Model.Affiliation
    {
        public ChangeAffiliationTransaction(int empid)
            : base(empid)
        {
        }

        public override void Change(Model.Employee e)
        {
            RecordMembership(e);

            Model.Affiliation af = GetAffiliation();
            e.SetAffiliation(af);
        }

        public abstract void RecordMembership(Model.Employee e);
        public abstract Model.Affiliation GetAffiliation();

        #region Affiliation Members

        public double CalculateDeductions(Model.Paycheck pc)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
