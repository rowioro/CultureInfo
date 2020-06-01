using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp9_CultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (var item in c)
            //{
            //    Console.Write(item.Name);
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);
            //}
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberDecimalSeparator = " kropka ";
            newCulture.NumberFormat.NegativeSign = " minus ";
            CultureInfo.CurrentCulture = newCulture;

            int a = -5;
            float b = 3.14f;
            Console.WriteLine($"{a}\n{b}");
            Console.ReadKey();
        }
    }
}
