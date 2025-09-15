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

while (jugandomas)
{

    Console.WriteLine("Escoge el numero una de tu posible jugada");
    Console.WriteLine("1.Piedra");
    Console.WriteLine("2.Papel");
    Console.WriteLine("3.Tijera");
    int gamer = int.Parse(Console.ReadLine()); //Recibe la respuesta del usuario y la tranforma en un numero que podemos usar en el switch
    int pc = compu.Next(1, 3); //Nos arrojara un valor ramdom para competir contra la computadora

    switch (gamer) //Este switch junto con los if determina si ganaste, perdiste o empataste con la maquina 
    {
        case 1: // Piedra
            Console.WriteLine("");
            if (pc == 1)
            {
                Console.WriteLine("La computadora y tu ambos han sacado piedra. Por lo tanto es --EMPATE--");
            }
            else if (pc == 3)
            {
                Console.WriteLine("La computadora saco Tijera y tu Piedra. Por lo tanto --GANASTE--");
            }
            else
            {
                Console.WriteLine("Oh la computadora saco Piedra y tu escogiste tijera. Lo siento --PERDISTE");
            }
            break;
        case 2: //Papel
            Console.WriteLine("");
            if (pc == 2)
            {
                Console.WriteLine("La computadora y tu ambos han sacado Papel. Por lo tanto es --EMPATE--");
            }
            else if (pc == 1)
            {
                Console.WriteLine("La computadora saco Piedra y tu Papel. Por lo tanto --GANASTE--");
            }
            else
            {
                Console.WriteLine("Oh no la computadora saco Papel y tu escogiste Piedra. Lo siento --PERDISTE");
            }
            break;
        case 3: //Tijera
            Console.WriteLine("");
            if (pc == 3)
            {
                Console.WriteLine("La computadora y tu ambos han sacado Tijera. Por lo tanto es --EMPATE--");
            }
            else if (pc == 2)
            {
                Console.WriteLine("La computadora saco Papel y tu Tijera. Por lo tanto --GANASTE--");
            }
            else
            {
                Console.WriteLine("Oh no la computadora saco Tijera y tu escogiste Papel. Lo siento --PERDISTE");
            }
            break;

    }

    Console.WriteLine("");

    Console.WriteLine("Quieres jugar otra vez (S/N)");
    Console.WriteLine("");
    string opt = Console.ReadLine().ToLower(); // Se aplica el Tolower para que la repuesta que arroje el usuario siempre el sistema la acepte en miniscula


    if (opt != "s")
    {

        jugandomas = false;
        Console.WriteLine("Gracias por jugar");
    }
}


