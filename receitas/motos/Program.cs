using System;

namespace motos
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Digite quantos kilometros de distância entre moto X e Y");
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }
    }
}
