using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Employee
    {
        private int itsEmpid;
        private string itsName;
        private string itsAddress;

        private PaymentClassification itsClassification;
        private PaymentSchedule itsSchedule;
        private PaymentMethod itsPaymentMethod;
        private Affiliation itsAffiliation;

        public Employee(int empid, string name, string address)
        {
            itsEmpid = empid;
            itsName = name;
            itsAddress = address;
            itsAffiliation = new NoAffiliation();
        }

        public void SetClassification(PaymentClassification pc)
        {
            itsClassification = pc;
        }

        public void SetSchedule(PaymentSchedule ps)
        {
            itsSchedule = ps;
        }

        public void SetMethod(PaymentMethod pm)
        {
            itsPaymentMethod = pm;
        }

        public string GetName()
        {
            return itsName;
        }

        public PaymentClassification GetClassification()
        {
            return itsClassification;
        }

        public PaymentSchedule GetSchedule()
        {
            return itsSchedule;
        }

        public PaymentMethod GetMethod()
        {
            return itsPaymentMethod;
        }

        public void SetAffiliation(Affiliation af)
        {
            itsAffiliation = af;
        }

        public Affiliation GetAffiliation()
        {
            return itsAffiliation;
        }

        public int GetEmpid()
        {
            return itsEmpid;
        }

        public void SetName(string name)
        {
            itsName = name;
        }

        public void SetAddress(string address)
        {
            itsAddress = address;
        }

        public string GetAddress()
        {
            return itsAddress;
        }


        public bool IsPayDate(DateTime payDate)
        {
            return itsSchedule.IsPaydate(payDate);
        }

        public DateTime GetPayPeriodStartDate(DateTime payPeriodEndDate)
        {
            return itsSchedule.GetPayPeriodStartDate(payPeriodEndDate);
        }

        public void Payday(Paycheck pc)
        {
            double grossPay = itsClassification.CalculatePay(pc);
            double deductions = itsAffiliation.CalculateDeductions(pc);
            double netPay = grossPay - deductions;
            pc.SetGrossPay(grossPay);
            pc.SetDeductions(deductions);
            pc.SetNetPay(netPay);
            itsPaymentMethod.Pay(pc);

        }
    }
}
