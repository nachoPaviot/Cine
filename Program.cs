using System;
using System.Collections;

namespace cineTP
{
    class Program
    {
            public static void Main(string[] args)
            {
                string Titulo = "vacio";
                string nSala = "vacio";
                string horario = "vacio";
                double pEntrada = 100.00;
                int cEntrada = 1;
                Stack pilaComentarios = new Stack();

                // ................................................................. //

               
                    var imagen = new[] /* array con los datos de la imagen a imprimir */
                            {
                         @"¦                                         ",
                         @"¦                                         ",
                         @"¦      _ __ ___   _____   _(_) ___  ___   ",
                         @"¦     | '_ ` _ \ / _ \ \ / / |/ _ \/ __|  ",
                         @"¦     | | | | | | (_) \ V /| |  __/\__ \  ",
                         @"¦     |_| |_| |_|\___/ \_/ |_|\___||___/  ",
                         @"¦                                         ",
                         @"¦                      @@@@@              ",
                         @"¦                    @@@@@@@@             ",
                         @"¦                00@00@@0@0@              ",
                         @"¦               |\@0@00@0@@@@/|           ",
                         @"¦               |         | | |           ",
                         @"¦               | ========| | |           ",
                         @"¦               | POPCORN | | |           ",
                         @"¦         @     | ========| | |  @        ",
                         @"¦     0  @0    | _________ | _ | _ | @@@@ ",
                    };
                    Console.WriteLine(("").PadRight(50, '-'));
                    foreach (string line in imagen)   /* Impresion linea por linea de la imagen */
                        Console.WriteLine(line);
                        Console.WriteLine(("").PadRight(50, '-'));
                        Console.WriteLine(("  \n"));

                    // ................................................................. //

                Console.Write("Bienvenidos Al Cine" + "\n");

                void menuPrincipal()
                    {
                    int a = 1;

                    while (a != 0)
                    {
                        Console.Write("\nMENU:" + "\n");
                        Console.Write("1) Ver Pelis y Horarios" + "\n" + "2) Comprar Entrada" + "\n" + "3) CandyBarr :)" + "\n" + "4) Publicar y ver comentarios" + "\n" + "0) Salir de la App" + "\n");
                        Console.Write("\nSeleccione una opción: ");
                        int dato = Convert.ToInt32(Console.ReadLine());

                        switch (dato)
                        {
                            case 1:
                                listaPelis();
                                break;

                            case 2:
                                imprimirEntradas();
                                break;

                            case 3:
                                candy();
                                break;

                            case 4:
                                comentariosPelis();
                                break;

                            case 0:
                                Console.Write("Gracias por visitar nuestra pagina.\n\n\n\n\n\n\n");
                                Console.ReadKey();
                                Environment.Exit(1);
                                break;

                            default:
                                Console.WriteLine("Mandaste cualquier cosa. Otra oportunidad...");
                                menuPrincipal();
                                break;
                        }
                    } 
              }

                void imprimirEntradas()
                {
                    /* Console.Write("\n IMPRIMIR ENTRADA \n");*/

                    Console.WriteLine("Cuantas entradas quieres comprar para la pelicula " + Titulo + "?");
                    cEntrada = Convert.ToInt32(Console.ReadLine());

                    /* Impresión por pantalla del Menu para seleccionar las cantidad de entradas a comprar  */

                    Console.WriteLine("  \n");
                    Console.WriteLine(("").PadRight(55, '-'));
                    Console.WriteLine("¦" + "Pelicula: " + Titulo);
                    Console.WriteLine("¦" + "Horario: " + horario);
                    Console.WriteLine("¦" + "Sala: " + nSala);
                    Console.WriteLine(("").PadRight(55, '-'));
                    Console.WriteLine("¦" + "Precio por Entrada: $" + (pEntrada));
                    Console.WriteLine("¦" + "Cantidad de Entradas: " + (cEntrada));
                    Console.WriteLine(("").PadRight(55, '-'));
                    Console.WriteLine("¦" + "Total Pagado: $" + (pEntrada * cEntrada));
                    Console.WriteLine(("").PadRight(55, '-'));
                    Console.WriteLine(("\n"));
                    Console.WriteLine(("\n"));
                    
                    menuPrincipal();
                }

                void listaPelis()
                {
                    Console.Write("LISTADO DE PELIS \n\n\n");

                    Console.Write("Seleccione una peli: \n" + " 1 - Shrek \n" + " 2 - Star Wars \n" + " 3 - Joker \n" + " 4 - Ratattouille:  Ahora en el IFTS!!! \n");

                    /* Impresión por pantalla del Menu para seleccionar las peliculas disponibles  */

                    int peli = Convert.ToInt32(Console.ReadLine());    /* ingreso por consola de la selección  */


                    if (peli == 1)     /* Selección de Pelis con sus variables asociadas para generar la compra  */
                    {
                        Console.WriteLine(" Nombre Peli: Shrek \n" + " Genero: Animado \n" + " Horarios: 20:00 \n" + " Sala: 1 \n");
                        Titulo = "Shrek";
                        horario = "20:00";
                        nSala = "1";

                    }
                    else if (peli == 2)
                    {
                        Console.WriteLine(" Nombre Peli: Star Wars \n" + " Genero: Ciencia Ficción \n" + " Horarios: 23:00 \n" + " Sala: 2 \n");
                        Titulo = "Star Wars";
                        horario = "23:00";
                        nSala = "2";

                    }
                    else if (peli == 3)
                    {
                        Console.WriteLine(" Nombre Peli: Joker \n" + " Genero: thriller psicológico \n" + " Horarios: 20:00 \n" + " Sala: 1 \n");
                        Titulo = "Joker";
                        horario = "20:00";
                        nSala = "1";

                    }
                    else if (peli == 4)
                    {
                        Console.WriteLine(" Nombre Peli: Ratattouille:  Ahora en el IFTS \n" + " Genero: Terror \n" + " Horarios: 23:00 \n" + " Sala: 2 \n");
                        Titulo = "Ratattouille:  Ahora en el IFTS";
                        horario = "23:00";
                        nSala = "2";
                    }
                menuPrincipal();
                }

                void candy()
                 {
                    Console.WriteLine("<<<<<<<<<<BIENVENIDO/A AL CANDY BAR>>>>>>>>>>");
                    Console.WriteLine("Seleccione la opccion \n" +
                        "\n1.-Hot Dog + Coca Cola 750 CC" +
                        "\n2.-Nachos + Coca cola 750 CC" +
                        "\n3.-Balde de pochoclos + 2 vasos de gaseosa 750 CC" +
                        "\n4.-Papas + Coca cola 750 CC " +
                        "\n5-Volver al menú principal");
                    String s1 = null;
                    s1 = Console.ReadLine();


                    switch (s1)
                    {
                        case "1":
                            Console.WriteLine("Opccion 1: $130");
                            candy();
                            break;
                        case "2":
                            Console.WriteLine("Opccion 2: $180");
                            candy();
                            break;
                        case "3":
                            Console.WriteLine("Opccion 3: $250");
                            candy();
                            break;
                        case "4":
                            Console.WriteLine("Opccion 2: $170");
                            candy();
                            break;
                        case "5":
                            menuPrincipal();
                            break;
                        default:
                            Console.WriteLine("No se ha seleccionado una opcion");
                            candy();
                            break;
                    }
                }

                void comentariosPelis()
                {
                    string eleccion;
                    Console.WriteLine("\nPublicar comentario(1)\nVer comentarios(2)\nVolver al menú principal(3)");
                    eleccion = Console.ReadLine();

                    switch (eleccion)
                    {
                        case "1":
                            nuevoComentario();
                            break;
                        case "2":
                            verComents();
                            break;
                        case "3":
                            menuPrincipal();
                            break;
                        default:
                            Console.WriteLine("Ingresó una opción errónea.");
                            comentariosPelis();
                            break;
                    }
                }

                void nuevoComentario()
                {
                    Console.WriteLine("Escriba su comentario por favor...\n");
                    pilaComentarios.Push(Console.ReadLine());

                    comentariosPelis();
                }

                void verComents()
                {
                    foreach (string j in pilaComentarios)
                    {
                        Console.WriteLine(j);
                    }
                    comentariosPelis();
                }

                menuPrincipal();
        }
        }
    }
