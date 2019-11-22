using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Joe Doe ";
            Console.WriteLine("Trim: {0}", fullName.Trim());
            Console.WriteLine("ToUpper: {0}", fullName.Trim().ToUpper());
            //var index = fullName.IndexOf(" ");
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index +1);
            //Console.WriteLine("First Name: " + firstName);
            //Console.WriteLine("Last Name: " + lastName);
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);
            Console.WriteLine("Names: {0}", fullName.Replace("Joe", "Joseph"));
            var str = "22";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);
            float price = 22.95f;
            Console.WriteLine(price.ToString("C"));
        }
    }
}
