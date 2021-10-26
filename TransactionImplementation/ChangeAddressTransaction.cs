using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeAddressTransaction : AbstractTransactions.ChangeEmployeeTransaction
    {
        private string itsAddress;

        public ChangeAddressTransaction(int empid,string address)
            :base(empid)
        {
            itsAddress = address;
        }

        public override void Change(Model.Employee e)
        {
            e.SetAddress(itsAddress);
        }
    }
}
