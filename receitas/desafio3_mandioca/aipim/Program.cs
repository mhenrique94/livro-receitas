using System;
using System.Linq;

namespace aipim
{
    public struct Program
    {
        static void Main() {

            try
            {

            int chico = 300 * Int32.Parse(Console.ReadLine());
            int bento = 1500 * Int32.Parse(Console.ReadLine());
            int bernardo = 600 * Int32.Parse(Console.ReadLine());
            int marina = 1000 * Int32.Parse(Console.ReadLine());
            int iara = 150 * Int32.Parse(Console.ReadLine());
            int marlene = 225;
            int total = chico + bento + bernardo + marina + iara + marlene; // Digite aqui o calculo total
            Console.WriteLine(total);
            }
                catch(FormatException)
                    {
                                Console.WriteLine("Erro, tente novamente digitando um número inteiro e pressionando ENTER!");
                    }          
        }
    }
}