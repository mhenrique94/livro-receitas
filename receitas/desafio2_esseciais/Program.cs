using System;
using System.Collections.Generic;
using System.Linq;

class Desafio {

    static void Main() {
        
        int numerodevezes = 3;

            for (int i = 1; i < numerodevezes; i++)

            {
                    int[] L = new int[3];
                    
                    L[i] = Int32.Parse(Console.ReadLine());
        
                    String Vi = Console.ReadLine();
                    char[] separador = { ',', ' ' };
                    Int32 count = 3;

                    String[] strlist = Vi.Split(separador, count, StringSplitOptions.None);
                    List<int> intlist = Array.ConvertAll(strlist, int.Parse).ToList();
                    
                    int [] max = new int [3];
                    max[i] = intlist.Max();
                    //Console.WriteLine(max);

                    foreach (int s in max){
                Console.WriteLine($"{s}");
                    }
            }
}
}
           
    //         if(max <= 10){
    //                     Console.WriteLine("1");
    //                 }if(max <= 20){
    //                     Console.WriteLine("2");
    //                 }else{
    //                     Console.WriteLine("3");
    //                 }
    // }



// Taking a string 
        // String str = "Geeks, For Geeks"; 
  
        // char[] spearator = { ',', ' ' }; 
        // Int32 count = 2; 
  
        // // Using the Method 
        // String[] strlist = str.Split(spearator,  
        //        count, StringSplitOptions.None); 
  
        // foreach(String s in strlist) 
        // { 
        //     Console.WriteLine(s); 
        // } 

// String str = "Geeks, For Geeks"; 
  
//         String[] spearator = { "s,", "For" }; 
  
//         // using the method 
//         String[] strlist = str.Split(spearator,  
//            StringSplitOptions.RemoveEmptyEntries); 
  
//         foreach(String s in strlist) 
//         { 
//             Console.WriteLine(s); 
//         } 


// string[] subs = s.Split(' ');

// foreach (var sub in subs)
// {
//     Console.WriteLine($"Substring: {sub}");
// }