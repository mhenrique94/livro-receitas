using System;

namespace workspace.livro_receitas
{
    public class desafio1
    {
//         static void Main(string[] args)
//         {
//             try
//                 {
//                 Console.WriteLine("\nOlá! Qual seu nome?");
//                 var name = Console.ReadLine();
//                 var date = DateTime.Now;

//                 Console.WriteLine($"\nOlá, {name}! É um prazer te conhecer!\nEsse é meu desafio, onde peço a você dois números e executo uma operação. Ok?");
//                 Console.WriteLine("\nOk! Então vamos direto ao ponto. Insira o primeiro número, por favor: ");
//                 int n1 = Int32.Parse(Console.ReadLine());

//                 Console.WriteLine("\nShow! Agora digite o segundo número: ");
//                 int n2 = Int32.Parse(Console.ReadLine());

                
//                         if (n2 == 0) {
//                         Console.WriteLine("divisao impossivel");
//                         } 
            
                  
            
//                         else {
//                             double divisao = n1 / n2; // Digite aqui o calculo da divisao
//                             Console.WriteLine(Math.Round(divisao,1));
//                         }
//             }

//                     catch (FormatException)
//                         {
//                             Console.WriteLine("-0.0");                 


//                         }
                    

//         }
//     }
// }
    static void Main() {
        
           {
               
               try
                {
                // int limit = Int32.Parse(Console.ReadLine());
                
                //  for (int i = 0; i < limit; i++)
                // {

                string[] line = Console.ReadLine().Split(" ");
                int X = Int32.Parse(line[0]);
                int Y = Int32.Parse(line[1]);
                double divisao;

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else if (X > 0 && Y > 0)
                {
                    divisao = X/Y;
                    Console.WriteLine(Math.Round(divisao, 1,MidpointRounding.AwayFromZero));
                }
                
                else if (X < 0 | Y < 0)
                    {
                        Console.WriteLine("-0.0");
                    }
                else
                    {
                        divisao = X/Y;
                        Console.WriteLine(Math.Round(divisao,1,MidpointRounding.AwayFromZero));
                    }
                }
                
                

                    catch(FormatException)
                        {
                            Console.WriteLine("-0.0");
                        }
                     catch(DivideByZeroException)
                        {
                            Console.WriteLine("-0.0");
                        }
                }
            }
}
}