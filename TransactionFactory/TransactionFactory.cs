using System;
using System.Reflection;


namespace TransactionFactory
{
    public class TransactionFactory
    {
        private static string path = "TransactionImplementation";

        public static object CreateModelIM(string className)
        {
            string classname = path + "." + className;
            return Assembly.Load(path).CreateInstance((classname);
        }
    }
}
