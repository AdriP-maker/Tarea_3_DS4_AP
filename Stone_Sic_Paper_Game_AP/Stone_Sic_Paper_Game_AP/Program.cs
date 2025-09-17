// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Programa para jugar piedra, papel o tijera simple

using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;



//Aclaración este programa se basa en el anterior solo que aca aplico los temas abordados en los videos del 14 al 16
//Sobre lo que es las sentencias de IF, el uso de Switch y el While
//Solo para que tenga en cuenta que estos distan un poco de los visto en los videos, pero es más para aplicarlo a un escenario más real o aplicando la lógica que conozco mas que todo.
//Continuamos

Random compu = new Random(); //Se crea una instancia de la clase ramdom para usar la función
bool jugandomas = true; //variable de control para el ciclo while 
Console.WriteLine("Vamos a ver como podemos jugar piedra, papel o tijera");
Console.WriteLine("");

//int piedra, papel, tijera;

//Esta funcionalidad del for le va quitar un poco de juego al tema por que sera como muy automático pero bueno
//Lo que busco es que el usuario al escoger un numero el programa haga como una simulación de 2 posibles jugadas repetidas de un mismo valor de forma automática
//Solo es para probar la funcionalidad del for y revisar un par de cositas del programa anterior 
//Aplicando lo visto en los videos de 17 al 19 

while (jugandomas)
{

    Console.WriteLine("Escoge el numero una de tu posible jugada");
    Console.WriteLine("1.Piedra");
    Console.WriteLine("2.Papel");
    Console.WriteLine("3.Tijera");
    int gamer = int.Parse(Console.ReadLine()); //Recibe la respuesta del usuario y la tranforma en un numero que podemos usar en el switch
    int victorias, empates, derrotas; // Son valores que determinaran cuantos resultados han pasado en cada ronda
    victorias = empates = derrotas = 0; //Se inicializan fueran del ciclo para que estan sean reconocidas tambien en resultados

    for (int i = 0; i < 2; i++)
    {
        int pc = compu.Next(1, 3); //Nos arrojara un valor ramdom para competir contra la computadora

        switch (gamer) //Este switch junto con los if determina si ganaste, perdiste o empataste con la maquina 
        {
            case 1: // Piedra
                Console.WriteLine("");
                if (pc == 1)
                {
                    Console.WriteLine("La computadora y tu ambos han sacado piedra. Por lo tanto es --EMPATE--");
                    empates++;
                }
                else if (pc == 3)
                {
                    Console.WriteLine("La computadora saco Tijera y tu Piedra. Por lo tanto --GANASTE--");
                    victorias++;
                }
                else
                {
                    Console.WriteLine("Oh la computadora saco Piedra y tu escogiste tijera. Lo siento --PERDISTE");
                    derrotas++;
                }
                break;
            case 2: //Papel
                Console.WriteLine("");
                if (pc == 2)
                {
                    Console.WriteLine("La computadora y tu ambos han sacado Papel. Por lo tanto es --EMPATE--");
                    empates++;
                }
                else if (pc == 1)
                {
                    Console.WriteLine("La computadora saco Piedra y tu Papel. Por lo tanto --GANASTE--");
                    victorias++;
                }
                else
                {
                    Console.WriteLine("Oh no la computadora saco Papel y tu escogiste Piedra. Lo siento --PERDISTE");
                    derrotas++;
                }
                break;
            case 3: //Tijera
                Console.WriteLine("");
                if (pc == 3)
                {
                    Console.WriteLine("La computadora y tu ambos han sacado Tijera. Por lo tanto es --EMPATE--");
                    empates++;
                }
                else if (pc == 2)
                {
                    Console.WriteLine("La computadora saco Papel y tu Tijera. Por lo tanto --GANASTE--");
                    victorias++;
                }
                else
                {
                    Console.WriteLine("Oh no la computadora saco Tijera y tu escogiste Papel. Lo siento --PERDISTE");
                    derrotas++;
                }
                break;

        }
    }
    string nom_jugada;
    if (gamer == 1) {
        nom_jugada = "Piedra";
        //Resultados de rondas automáticas
        Console.WriteLine("");
        Console.WriteLine("LISTA DE RESULTADOS para la jugada de: " + nom_jugada);
        Console.WriteLine($"Victorias: {victorias}");
        Console.WriteLine($"Empates: {empates}");
        Console.WriteLine($"Derrotas:{derrotas}");

    } else if (gamer == 2) {
        nom_jugada = "Papel";
        Console.WriteLine("");
        Console.WriteLine("LISTA DE RESULTADOS para la jugada de: " + nom_jugada);
        Console.WriteLine($"Victorias: {victorias}");
        Console.WriteLine($"Empates: {empates}");
        Console.WriteLine($"Derrotas:{derrotas}");
    }
    else {
        nom_jugada = "Tijera";
        Console.WriteLine("");
        Console.WriteLine("LISTA DE RESULTADOS para la jugada de: " + nom_jugada);
        Console.WriteLine($"Victorias: {victorias}");
        Console.WriteLine($"Empates: {empates}");
        Console.WriteLine($"Derrotas:{derrotas}");
    }


    Console.WriteLine("");

    Console.WriteLine("Quieres jugar otra vez (S/N) o (SI/NO)"); //Aca se agrega una validación extra con la palabra por si el usuario le da por escribir de más
    Console.WriteLine("");
    string opt = Console.ReadLine().ToLower(); // Se aplica el Tolower para que la repuesta que arroje el usuario siempre el sistema la acepte en miniscula


    if (opt != "s" && opt!="si")
    {

        jugandomas = false; // No fue por comentado por lo mismo anteriormente, esto basicamente es una correción vista en el video 17, pero que ya he aplicado anteriormente ya que en vez de una lectura esta se almacena en una variable que es leida y verificada 
        int i = 0;
        Console.WriteLine("Gracias por jugar");
    }
}


