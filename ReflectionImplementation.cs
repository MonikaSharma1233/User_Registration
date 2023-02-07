using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class ReflectionImplementation
    {
        public static void reflect()
        {
            UserDetails UD=new UserDetails();
            Type type = Type.GetType("UserRegistrationRegex.CustroctorInfo");
            Console.WriteLine("Methods in UserDetails class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("Properties in UserDetails class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in UserDetails class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
