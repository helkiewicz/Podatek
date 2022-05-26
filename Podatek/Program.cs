using System;

namespace Podatek
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal VAT = 0.22M;

            decimal netto;

            Console.Write("Podaj cenę netto: ");
            netto = Convert.ToDecimal(Console.ReadLine());

            decimal podatek = VAT * netto;
            decimal brutto = netto + podatek;

            Console.WriteLine("Cena wynosi {0} zł, w tym kwota podatku {1} zł.", brutto, podatek);
            Console.ReadKey();
        }
    }
}