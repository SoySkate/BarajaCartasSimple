using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaDeCartas
{
    class Program
    {
        class Carta
        {
            //Atributos/Miembros
            int numero;
            int palo;
            string[] palos = { "Oros", "Copas", "Espadas", "Bastos" };

            //Construcor
            public Carta(int n, int p)
            {
                numero = n;
                palo = p;
            }
            //Metodo
            public void EscribirCarta()
            {
                Console.WriteLine(numero + " de " + palos[palo]);
            }
        }
        class Baraja
        {
            List<Carta> cartas = new List<Carta>();

            public Baraja()
            {
                //Random aleatorio = new Random();
                //int[] numero_card = new int[12];
                //int[] tipo_card = new int[4];

                for (int i = 0; i < 4; i++)
                {
                    //tipo_card[i] = aleatorio.Next(0, 3) + 1;
                    for (int j = 0; j < 12; j++)
                    {
                        //numero_card[j] = aleatorio.Next(0, 11) + 1;
                        Carta card = new Carta(j+1, i);
                        cartas.Add(card);
                    }
                }
            }

            public void numeroCartas()
            {
                Console.WriteLine("En la baraja hay: " + cartas.Count + " cartas.");
                //for (int i = 0; i < cartas.Count; i++)
                //{
                //    Console.WriteLine((i + 1) + "-" + cartas[i]);
                //}
                //Console.ReadKey();
            }

            public void robaCarta()
            {
                Console.WriteLine("Has robado la carta: ");
               cartas[0].EscribirCarta();
                cartas.RemoveAt(0);
            }
            public void cogeCarta(int n)
            {
                Console.WriteLine("Has cogido la carta: ");
                cartas[n].EscribirCarta();
                cartas.RemoveAt(n);
                //cartas.Remove(cartas[0]);

            }
            public void cogeRandomCard()
            {
                Random aleatorio = new Random();
                int numcarta = aleatorio.Next(0, cartas.Count) + 1;
                Console.WriteLine("Has cogido la carta: ");
                cartas[numcarta].EscribirCarta();
                cartas.RemoveAt(numcarta);
            }
            public void escribeBaraja()
            {
                for (int i=0; i<cartas.Count; i++)
                {
                    cartas[i].EscribirCarta();
                }
            }
            public void Barajar()
            {
                Random aleatorio = new Random();
                var randomizado = cartas.OrderBy(item => aleatorio.Next());
                escribeBaraja();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Este es un ejercicio de una Baraja de Cartas");
            Boolean menu = true;
            Baraja primeraBaraja = new Baraja();
            do
            {
                Console.WriteLine("Menú de opciones");
                Console.WriteLine("1.Saber cuantas cartas tiene la baraja actualmente.");
                Console.WriteLine("2.Robar carta de la baraja.(Muestra y elimina la primera carta de la baraja)");
                Console.WriteLine("3.Coge la carta (escribe en pantalla) que está en la posición (n) pasada por parámetro y la saca de la baraja..");
                Console.WriteLine("4.Coge una carta (escribe en pantalla) al azar y la saca de la baraja..");
                Console.WriteLine("5. Escribe el nombre de todas las cartas de la baraja (una por línea).");
                Console.WriteLine("6.Mezcla las cartas en la lista.");
                int opcion = int.Parse(Console.ReadLine());
               
                if (menu == true)
                {
                   
                    switch (opcion)
                    {
                        case 1:
                            primeraBaraja.numeroCartas();
                            Console.ReadKey();
                            //MEJORAR: Que no se repitan los numeroS de las cartas Y HAY DEMASIADAS CARTAS
                            //DE UN SOLO PALO
                            break;
                        case 2:
                            primeraBaraja.robaCarta();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Introduzca el numero de la carta de la lista que desea coger:");
                            int numero = int.Parse(Console.ReadLine());
                            primeraBaraja.cogeCarta(numero);
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Ha elegido sacar una carta de forma aleatoria:\n");
                            primeraBaraja.cogeRandomCard();
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("A continuacion se va a mostrar toda la baraja:\n");
                            primeraBaraja.escribeBaraja();
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.WriteLine("Has seleccionado la opcion de barajar la baraja:\n");
                            primeraBaraja.Barajar();
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.WriteLine("SALIENDO...\n");
                            Console.WriteLine("PULSA CUALQUIER TECLA PARA SALIR:\n");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("You didn't choose any viable option...");
                            Console.ReadKey();
                            break;
                    }

                }


            } while (menu == true);

        }
    }
}
