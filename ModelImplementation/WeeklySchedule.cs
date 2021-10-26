using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class WeeklySchedule : Model.PaymentSchedule
    {
        public bool IsPaydate(DateTime payDate)
        {
            return payDate.DayOfWeek == DayOfWeek.Friday;
        }

        public DateTime GetPayPeriodStartDate(DateTime payPeriodEndDate)
        {
            return payPeriodEndDate.AddDays( - 6);    // the previous Saturday.
        }

    }
}
