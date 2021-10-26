using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class SalariedClassification : Model.PaymentClassification
    {
        private double itsSalary;

        public SalariedClassification(double salary)
        {
            itsSalary = salary;
        }

        public double GetSalary()
        {
            return itsSalary;
        }

        #region PaymentClassification Members

        public double CalculatePay(Model.Paycheck pc)
        {
            return itsSalary;
        }

        #endregion
    }
}
