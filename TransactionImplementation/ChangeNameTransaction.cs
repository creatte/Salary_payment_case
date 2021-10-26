using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeNameTransaction : AbstractTransactions.ChangeEmployeeTransaction
    {
        private string itsName;

        public ChangeNameTransaction(int empid,string name)
            :base(empid)
        {
            itsName = name;
        }

        public override void Change(Model.Employee e)
        {
            e.SetName(itsName);
        }
    }
}
