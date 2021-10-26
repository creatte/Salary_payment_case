using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Paycheck
    {
        private readonly DateTime itsPayPeriodStartDate;
        private readonly DateTime itsPayPeriodEndDate;
        private double itsGrossPay;
        private double itsNetPay;
        private double itsDeductions;
        private Dictionary<string, string> itsFields = new Dictionary<string,string>(10);

        public Paycheck(DateTime payPeriodStart, DateTime payPeriodEnd)
        {
            itsPayPeriodStartDate = payPeriodStart;
            itsPayPeriodEndDate = payPeriodEnd;
        }

        public void SetGrossPay(double grossPay)
        {
            itsGrossPay = grossPay;
        }

        public void SetDeductions(double deductions)
        {
            itsDeductions = deductions;
        }

        public void SetNetPay(double netPay)
        {
            itsNetPay = netPay;
        }


        public DateTime GetPayPeriodEndDate()
        {
            return itsPayPeriodEndDate;
        }

        public double GetGrossPay()
        {
            return itsGrossPay;
        }

        public string GetField(string name)
        {
            return itsFields[name];
        }

        public double GetDeductions()
        {
            return itsDeductions;
        }

        public double GetNetPay()
        {
            return itsNetPay;
        }

        public void SetField(string name, string value)
        {
            itsFields.Add(name, value);
        }

        public DateTime GetPayPeriodStartDate()
        {
            return itsPayPeriodStartDate;
        }
    }
}
