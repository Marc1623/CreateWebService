using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            Calclator.CalculatorClient client = new Calclator.CalculatorClient();
            var result = client.Add(2, 6);
            Console.WriteLine("Add : " + result);



            result = client.Div(100, 5);
            Console.WriteLine("Div : " + result);



            Console.ReadKey();
        }
    }
}
