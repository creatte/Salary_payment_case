using System;
using System.Collections.Generic;
using System.Text;
//工资支付时间借口
namespace Model
{
    public interface PaymentSchedule
    {
        bool IsPaydate(DateTime payDate);
        DateTime GetPayPeriodStartDate(DateTime payPeriodEndDate);
    }
}
