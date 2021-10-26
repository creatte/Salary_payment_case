using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface PaymentClassification
    {
        double CalculatePay(Paycheck pc);
    }
}
