using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_SBLG_1104822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double libra, dolar, yen, cuenteurosl, cuenteurosd, cuenteurosy;

            Console.WriteLine("Ingrese la cantidad de libras");
            libra = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad en dolares");
            dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad en yen");
            yen = double.Parse(Console.ReadLine());

            cuenteurosl = libra * 1.22;
            cuenteurosd = dolar * 0.75;
            cuenteurosy = yen * 0.009;

            Console.WriteLine(libra + "libras a euros es: {0}", cuenteurosl);
            Console.ReadLine();
            Console.WriteLine(dolar + "dolares a euros es: {0}",cuenteurosd);
            Console.ReadLine();
            Console.WriteLine(yen + "yenes a euros es: {0}",cuenteurosy);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
