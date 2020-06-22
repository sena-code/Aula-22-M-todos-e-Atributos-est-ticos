using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Conversor.Dolar = 5.30f;
            Console.WriteLine("Valor de 24 $ para o valor em Real: " +Conversor.DolarforReal(24));
            Conversor.Euro = 5.92f;
            Console.WriteLine("Valor de 24 euros para o valor em Real: " +Conversor.EuroforReal(24));
            Console.WriteLine("Valor de 500 R$ para o valor em Dolar: " +Conversor.RealforDolar(500));
            Console.WriteLine("Valor de 2000 R$ para o valor em Euros: " +Conversor.RealforEuro(2000));

        }
    }
}
