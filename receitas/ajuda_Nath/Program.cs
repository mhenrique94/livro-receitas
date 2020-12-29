using System;

class conversaoDeTempo {

static void Main() {

    var tempo = Int32.Parse(Console.ReadLine());

    if(tempo > 0 ){

    int horas = tempo / 3600;

    int minutos = (tempo % 3600) / 60 ;

    int segundos =  (tempo % 3600) % 60;

    Console.WriteLine($"" + horas + ":" + minutos + ":" + segundos);
    } else{
        Console.WriteLine("Insira um numero válido!");
    }
}
}