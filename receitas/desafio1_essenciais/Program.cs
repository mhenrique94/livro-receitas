using System;

    class Desafio
    {
        static void Main(){

        try{
                
            Console.WriteLine("\nInsira um número de 1 a 1000: ");
            var meuNumero = Int32.Parse(Console.ReadLine());

                for (int i=1; i<= meuNumero; i++)
                {
                    var resultado = $"{i} {i*i} {i*i*i}";
                    //var resultado = $"{i} {i^2} {i^3}";
                    Console.WriteLine(resultado);
                }

        }
                
                catch(FormatException){
                    Console.WriteLine("\nInsira um número de 1 a 1000! ");
                }
                finally{
                    var meuNumero = Int32.Parse(Console.ReadLine());

                for (int i=1; i<= meuNumero; i++)
                {
                    var resultado = $"{i} {i*i} {i*i*i}";
                    Console.WriteLine(resultado);
                }
                }
        }
        }

//PARA O CONSOLE DA DIO
// using System;

// class Desafio {
//     static void Main() {
//         var numero = Int32.Parse(Console.ReadLine());
        
//         if(numero != 0)
//         {
//           for(int i = 1; i <= numero; i++)
//           {
//             var numeros = $"{i} {i * i} {i * i * i}";
//             Console.WriteLine(numeros);
//           }
//         } else {
//           Console.WriteLine("Insira um número!");
//         }
//     }
// }
