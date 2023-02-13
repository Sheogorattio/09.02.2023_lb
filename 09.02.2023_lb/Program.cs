using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClass;

namespace _09._02._2023_lb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card obj = new Card();
            Card obj2 = new Card();
            obj2.CVC = 120.ToString();
            
            obj.CVC = 120.ToString();

            Console.WriteLine(obj.CVC == obj2.CVC);

            obj.Number =1234567890123456.ToString();

            obj.Name = "name";

            obj.Surname = "surname";

            Console.WriteLine("Name:\t{0}\nSurname:\t{1}\nNumber:\t{2}\nCVC:\t{3}", obj.Name, obj.Surname, obj.Number, obj.CVC);
            
            Console.ReadKey();
        }
    }
}
