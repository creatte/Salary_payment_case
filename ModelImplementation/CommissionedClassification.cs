using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class CommissionedClassification : Model.PaymentClassification
    {
        private double itsCommissionRate;
        private double itsSalary;
        private Dictionary<DateTime, SalesReceipt> itsReceipts = new Dictionary<DateTime,SalesReceipt>(10);

        public CommissionedClassification(double salary,double commissionalRate)
        {
            itsSalary = salary;
            itsCommissionRate = commissionalRate;
        }

        public double GetSalary()
        {
            return itsSalary;
        }

        public void AddSalesReceipt(SalesReceipt sr)
        {
            itsReceipts.Add(sr.GetSaleDate(), sr);
        }

        public SalesReceipt GetReceipt(DateTime date)
        {
            return itsReceipts[date];
        }

        public double GetRate()
        {
            return itsCommissionRate;
        }

        #region PaymentClassification Members

        public double CalculatePay(Model.Paycheck pc)
        {
            double commission = 0.0;

            foreach (DateTime date in itsReceipts.Keys)
            {
                SalesReceipt receipt = itsReceipts[date];
                DateTime dt1, dt2;
                dt1 = pc.GetPayPeriodStartDate();
                dt2 = pc.GetPayPeriodEndDate();
                if (date >= dt1 && date <= dt2)
                {
                    commission += receipt.GetAmount() * itsCommissionRate;
                }
            }

            return itsSalary + commission;
  
        }

        #endregion
    }
}
