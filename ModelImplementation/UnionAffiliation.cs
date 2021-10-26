using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class UnionAffiliation : Model.Affiliation
    {
        private int itsMemberId;
        private double itsDues;
        private Dictionary<DateTime, ServiceCharge> itsServiceCharges = new Dictionary<DateTime, ServiceCharge>(10);

        public UnionAffiliation(int memberId, double dues)
        {
            itsMemberId = memberId;
            itsDues = dues;
        }

        public ServiceCharge GetServiceCharge(DateTime date)
        {
            return itsServiceCharges[date];
        }

        public void AddServiceCharge(DateTime date, double amount)
        {
            ServiceCharge sc = new ServiceCharge(date, amount);
            itsServiceCharges.Add(date, sc);
        }

        public double GetDues()
        {
            return itsDues;
        }

        public int GetMemberId()
        {
            return itsMemberId;
        }

        #region Affiliation Members

        public double CalculateDeductions(Model.Paycheck pc)
        {
            double totalServiceCharge = 0;
            double totalDues = 0;

            foreach (DateTime date in itsServiceCharges.Keys)
            {
                ServiceCharge sc = itsServiceCharges[date];
                DateTime dt1, dt2;
                dt1 = pc.GetPayPeriodStartDate();
                dt2 = pc.GetPayPeriodEndDate();
                if (date >= dt1 && date <= dt2)
                {
                    totalServiceCharge += sc.GetAmount();
                }
            }

            int fridays = NumberOfFridaysInPayPeriod(pc.GetPayPeriodStartDate(),
                       pc.GetPayPeriodEndDate());
            totalDues = itsDues * fridays;
            return totalDues + totalServiceCharge;
        }

        private int NumberOfFridaysInPayPeriod(DateTime payPeriodStart, DateTime payPeriodEnd)
        {
            int fridays = 0;
            for (DateTime date = payPeriodStart; date <= payPeriodEnd; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Friday)
                    fridays++;
            }

            return fridays;
        }

        #endregion
    }
}
