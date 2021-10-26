using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class TimeCardTransaction : TransactionApplication.Transaction
    {
        private readonly DateTime itsDate;
        private double itsHours;
        private int itsEmpid;

        public TimeCardTransaction(DateTime date, double hours, int empid)
        {
            itsDate = date;
            itsHours = hours;
            itsEmpid = empid;
        }


        public void Execute()
        {
            Model.Employee e = DataBase.PayrollDatabase.Default.GetEmployee(itsEmpid);
            if (e != null)
            {
                Model.PaymentClassification pc = e.GetClassification();
                if (pc is ModelImplementation.HourlyClassification)
                {
                    ModelImplementation.HourlyClassification hc = (ModelImplementation.HourlyClassification)e.GetClassification();
                    hc.AddTimeCard(new ModelImplementation.TimeCard(itsDate, itsHours));
                }
                else
                    throw new Exception(DataBase.PayrollExceptionMessage.NotHoulyClassification);

            }
            else
                throw new Exception(DataBase.PayrollExceptionMessage.EmployeeNotExist);
        }

    }
}
