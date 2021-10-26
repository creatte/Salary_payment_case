using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class ServiceChargeTransaction : TransactionApplication.Transaction
    {
        private readonly DateTime itsDate;
        private double itsCharge;
        private int itsMemberId;

        public ServiceChargeTransaction(int memberId, DateTime date, double charge)
        {
            itsMemberId = memberId;
            itsDate = date;
            itsCharge = charge;
        }

        public void Execute()
        {
            Model.Employee e = DataBase.PayrollDatabase.Default.GetUnionMember(itsMemberId);
            Model.Affiliation af = e.GetAffiliation();
            if (af is ModelImplementation.UnionAffiliation)
            {
                ModelImplementation.UnionAffiliation uaf = (ModelImplementation.UnionAffiliation)af;
                uaf.AddServiceCharge(itsDate, itsCharge);
            }
        }

    }
}
