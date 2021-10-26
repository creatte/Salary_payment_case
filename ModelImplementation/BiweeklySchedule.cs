using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class BiweeklySchedule : Model.PaymentSchedule
    {
        public bool IsPaydate(DateTime payDate)
        {
            DateTime firstPayableFriday = new DateTime(2001, 11, 9);

            TimeSpan ts = payDate.Subtract(firstPayableFriday);

            int daysSinceFirstPayableFriday = ts.Days;
            return (daysSinceFirstPayableFriday % 14) == 0; //  two weeks.
        }

        public DateTime GetPayPeriodStartDate(DateTime payPeriodEndDate)
        {
            return payPeriodEndDate.AddDays( - 13); // Saturday, two weeks ago.
        }

    }
}
