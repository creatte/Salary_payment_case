using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public static class PayrollExceptionMessage
    {
        public const string EmployeeNotExist = "不存在该雇员";
        public const string NotHoulyClassification = "该雇员不是时薪雇员。";
        public const string NotCommissionedClassification = "该雇员不是佣金雇员。";
    }
}
