using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class SalesReceipt
    {
        private readonly DateTime itsSaleDate;
        double itsAmount;

        public SalesReceipt(DateTime saleDate, double amount)
        {
            itsSaleDate = saleDate;
            itsAmount = amount;
        }

        public double GetAmount()
        {
            return itsAmount;
        }

        public DateTime GetSaleDate()
        {
            return itsSaleDate;
        }
    }
}
