using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTransactions
{
    public abstract class ChangeMethodTransaction : ChangeEmployeeTransaction, Model.PaymentMethod
    {
        public ChangeMethodTransaction(int empid)
            : base(empid)
        {
        }

        public override void Change(Model.Employee e)
        {
            Model.PaymentMethod pm = GetMethod();
            e.SetMethod(pm);
        }

        public abstract Model.PaymentMethod GetMethod();


        #region PaymentMethod Members

        public void Pay(Model.Paycheck pc)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
