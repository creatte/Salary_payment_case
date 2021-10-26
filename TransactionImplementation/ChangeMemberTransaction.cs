using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ChangeMemberTransaction : AbstractTransactions.ChangeAffiliationTransaction
    {
        private double itsDues;
        private int itsMemberId;

        public ChangeMemberTransaction(int empid,int memberid,double dues)
            : base(empid)
        {
            itsMemberId = memberid;
            itsDues = dues;
        }

        public override void RecordMembership(Model.Employee e)
        {
            DataBase.PayrollDatabase.Default.AddUnionMember(itsMemberId, e);
        }

        public override Model.Affiliation GetAffiliation()
        {
            return new ModelImplementation.UnionAffiliation(itsMemberId, itsDues);
        }
    }
}
