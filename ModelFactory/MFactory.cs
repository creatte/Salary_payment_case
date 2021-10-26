using System;
using System.Reflection;


namespace ModelFactory
{
    public sealed class  MFactory
    {
        private static string path = "ModelImplementation";

        public static object CreateModelIM(string className)
        {
            string classname = path + "." + className;
            return Assembly.Load(path).CreateInstance(classname);
        }
    }
}
