using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeUnaffiliatedTransaction : AbstractTransactions.ChangeAffiliationTransaction
    {
        public ChangeUnaffiliatedTransaction(int empid)
            : base(empid)
        {
        }

        public override void RecordMembership(Model.Employee e)
        {
            Model.Affiliation af = e.GetAffiliation();
            if (af is ModelImplementation.UnionAffiliation)
            {
                ModelImplementation.UnionAffiliation uaf = (ModelImplementation.UnionAffiliation)af;
                int memberId = uaf.GetMemberId();
                DataBase.PayrollDatabase.Default.RemoveUnionMember(memberId);
            }
        }

        public override Model.Affiliation GetAffiliation()
        {
            return new Model.NoAffiliation();
        }
    }
}
