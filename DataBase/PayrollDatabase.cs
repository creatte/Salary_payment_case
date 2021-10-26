using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class PayrollDatabase
    {
        private static PayrollDatabase theInstance = new PayrollDatabase();
        private Dictionary<int, Model.Employee> itsEmployees = new Dictionary<int, Model.Employee>(10);
        private Dictionary<int, int> itsUnionMembers = new Dictionary<int, int>(10);

        public void clear()
        {
            itsEmployees.Clear();
            itsUnionMembers.Clear();
        }

        public Model.Employee GetEmployee(int empid)
        {
            if (itsEmployees.ContainsKey(empid))
                return itsEmployees[empid];
            else
                return null;
        }

        public void AddEmployee(int empid, Model.Employee e)
        {
            itsEmployees.Add(empid, e);
        }

        private PayrollDatabase()
        {
        }

        public static PayrollDatabase Default
        {
            get
            {
                return theInstance;
            }
        }

        public void DeleteEmployee(int empid)
        {
            itsEmployees.Remove(empid);
        }

        public void AddUnionMember(int memberid, Model.Employee e)
        {
            int empid = e.GetEmpid();
            itsUnionMembers.Add(memberid, empid);
        }

        public Model.Employee GetUnionMember(int memberid)
        {
            if (itsUnionMembers.ContainsKey(memberid))
            {
                int empid = itsUnionMembers[memberid];
                return itsEmployees[empid];
            }
            else
                return null;
        }

        public void RemoveUnionMember(int memberId)
        {
            itsUnionMembers.Remove(memberId);
        }

        public List<int> GetAllEmployeeIds()
        {
            List<int> empIds = new List<int>(10);
            foreach (int empid in itsEmployees.Keys)
            {
                empIds.Add(empid);
            }

            return empIds;
        }
    }
}
