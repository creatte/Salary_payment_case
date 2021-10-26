using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface PaymentSchedule
    {
        bool IsPaydate(DateTime payDate);
        DateTime GetPayPeriodStartDate(DateTime payPeriodEndDate);
    }
}
