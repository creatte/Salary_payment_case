using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class MonthlySchedule : Model.PaymentSchedule
    {
        public bool IsLastDayOfMonth(DateTime date)
        {
            int m1 = date.Month;
            int m2 = date.AddDays(1).Month;

            return (m1 != m2);
        }

        public bool IsPaydate(DateTime payDate)
        {
            return IsLastDayOfMonth(payDate);
        }

        public DateTime GetPayPeriodStartDate(DateTime payPeriodEndDate)
        {
            int lastDayOfMonth = payPeriodEndDate.Day;
            DateTime firstDayOfMonth = payPeriodEndDate.AddDays(-(lastDayOfMonth - 1));
            return firstDayOfMonth;
        }

    }
}
