using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionImplementation
{
    public class PaydayTransaction:TransactionApplication.Transaction
    {
        private DateTime itsPayDate;
        private Dictionary<int, Model.Paycheck> itsPaychecks = new Dictionary<int, Model.Paycheck>(10);

        public PaydayTransaction(DateTime payDate)
        {
            itsPayDate = payDate;
        }

        public void Execute()
        {
            List<int> empIds;
            empIds = DataBase.PayrollDatabase.Default.GetAllEmployeeIds();

            foreach (int empId in empIds)
            {
                Model.Employee e = DataBase.PayrollDatabase.Default.GetEmployee(empId);
                if (e != null)
                {
                    if (e.IsPayDate(itsPayDate))
                    {
                        Model.Paycheck pc = new Model.Paycheck(e.GetPayPeriodStartDate(itsPayDate), itsPayDate);
                        itsPaychecks.Add(empId, pc);
                        e.Payday(pc);
                    }
                }
            }

        }


        public Model.Paycheck GetPaycheck(int empId)
        {
            if (itsPaychecks.ContainsKey(empId))
                return itsPaychecks[empId];
            else
                return null;

        }

        public int GetPaycheckCount()
        {
            return itsPaychecks.Count;
        }
    }
}
