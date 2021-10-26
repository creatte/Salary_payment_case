using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class SalesReceiptTransaction : TransactionApplication.Transaction
    {
        private int itsEmpid;
        private readonly DateTime itsSalesDate;
        private double itsAmount;

        public SalesReceiptTransaction(DateTime saleDate, double amount, int empid)
        {
            itsSalesDate = saleDate;
            itsAmount = amount;
            itsEmpid = empid;
        }

        public void Execute()
        {
            Model.Employee e = DataBase.PayrollDatabase.Default.GetEmployee(itsEmpid);
            if (e != null)
            {
                Model.PaymentClassification pc = e.GetClassification();
                if (pc is ModelImplementation.CommissionedClassification)
                {
                    ModelImplementation.CommissionedClassification cc = (ModelImplementation.CommissionedClassification)pc;
                    ModelImplementation.SalesReceipt sr = new ModelImplementation.SalesReceipt(itsSalesDate, itsAmount);
                    cc.AddSalesReceipt(sr);
                }
                else
                    throw new Exception(DataBase.PayrollExceptionMessage.NotCommissionedClassification);
            }
            else
                throw new Exception(DataBase.PayrollExceptionMessage.EmployeeNotExist);
        }

    }
}
