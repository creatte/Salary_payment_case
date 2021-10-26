using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class ServiceCharge
    {
        private readonly DateTime itsDate;
        private double itsAmount;

        public ServiceCharge(DateTime date, double amount)
        {
            itsDate = date;
            itsAmount = amount;
        }

        public double GetAmount()
        {
            return itsAmount;
        }
    }
}
