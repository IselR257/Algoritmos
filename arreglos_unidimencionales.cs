﻿using System;
					
public class arreglos_unidimencionales
{
	public static void Main()
	{
        int opc;
        int buffer;
        int arreglo;
        int[] list = new int[0];
        arreglo=0;
        opc=0;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU DE ARREGLOS UNIDIMENSIONALES");
            Console.WriteLine("1. Ingrese el tamaño del arreglo");
            Console.WriteLine("2. Ingresar valores al arreglo");
            Console.WriteLine("3. Imprimir valores del arreglo");
            Console.WriteLine("4. Imprimir el valor mas alto del arreglo");
            Console.WriteLine("5. Imprimir el valor mas bajo del arreglo");
            Console.WriteLine("6. Imprimir la suma total del arreglo");
            Console.WriteLine("7. Imprimir el arreglo al reves");
            Console.WriteLine("8. Salir");

            Console.WriteLine("Ingresar opcion del menu: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese el tamaño del arreglo");
                    arreglo=Convert.ToInt32(Console.ReadLine());
                    list = new int[arreglo];
                    Console.WriteLine("Proceso finalizado...");
                    break;
                case 2:
                    Console.WriteLine("Ingresando valores al arreglo");
                    for (int i = 0; i < list.Length; i++)
                    {
                        Console.WriteLine("Ingrese un numero para la posición " + i);
                        list[i]=Convert.ToInt32(Console.ReadLine());     
                    }
                    Console.WriteLine("Proceso finalizado...");
                    break;
                case 3:
                    Console.WriteLine("Imprimiendo valores del arreglo");
                    for (int i = 0; i < list.Length; i++)
                    {
                        Console.WriteLine("Posición [" + i + "]: " + list[i]);    
                    }
                    break;
                case 4:
                    Console.WriteLine("Imprimiendo el valor mas alto del arreglo");
                    buffer=0;
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i]>buffer)
                        {
                            buffer=list[i];
                        }
                    }
                    Console.WriteLine("El numero mayor es: " + buffer);
                    break;
                case 5:
                    Console.WriteLine("Imprimiendo el valor mas bajo del arreglo");
                    buffer=0;
                    for (int i = 0; i < list.Length; i++)
                    {   
                        if (i==0)
                        {
                            buffer=list[i];
                        }
                        else
                        {
                            if (list[i]<buffer)
                            {
                                buffer=list[i];
                            }    
                        }
                    }
                    Console.WriteLine("El numero menor es: " + buffer);
                    break;
                case 6:
                    Console.WriteLine("Imprimiendo la suma total del arreglo");
                    buffer=0;
                    for (int i = 0; i < list.Length; i++)
                    {
                        buffer=buffer+list[i];   
                    }
                    Console.WriteLine("La suma del arreglo es: " + buffer);
                    break;
                case 7:
                    Console.WriteLine("Imprimiendo el arreglo al reves");
                    for (int i = list.Length-1; i>=0; i--)
                    {
                        Console.WriteLine("Posicion [" + i +"]:" + list[i]);
                    }
                    break;
                case 8:
                    Console.WriteLine("Adios, gracias por usar el programa");
                    break;
                default:
                    Console.WriteLine("Opps algo salio mal, ingrese una opcion de nuevo");
                    break;
            }
            Console.ReadKey();
        } while (opc!=8);
    }
}