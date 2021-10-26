using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class HourlyClassification : Model.PaymentClassification
    {
        private double itsRate;
        private Dictionary<DateTime, TimeCard> itsTimeCards = new Dictionary<DateTime,TimeCard>(10);

        public HourlyClassification(double hourlyRate)
        {
            itsRate = hourlyRate;
        }

        public double GetRate()
        {
            return itsRate;
        }


        public TimeCard GetTimeCard(DateTime date)
        {
            return itsTimeCards[date];
        }

        public void AddTimeCard(TimeCard tc)
        {
            itsTimeCards.Add(tc.GetDate(), tc);
        }

        private double CalculatePayForTimeCard(TimeCard tc)
        {
            double hours = tc.GetHours();
            double overtime = Math.Max(0.0, hours - 8.0);
            double straightTime = hours - overtime;
            return straightTime * itsRate + overtime * itsRate * 1.5;
        }

        #region PaymentClassification Members

        public double CalculatePay(Model.Paycheck pc)
        {
            double totalPay = 0;
            DateTime payPeriodEndDate = pc.GetPayPeriodEndDate();
            foreach (DateTime date in itsTimeCards.Keys)
            {
                TimeCard tc = itsTimeCards[date];

                DateTime dt1, dt2;
                dt1 = pc.GetPayPeriodStartDate();
                dt2 = pc.GetPayPeriodEndDate();
                if (date >= dt1 && date <= dt2)
                {
                    totalPay += CalculatePayForTimeCard(tc);
                }
            }

            return totalPay;
        }

        #endregion
    }
}
