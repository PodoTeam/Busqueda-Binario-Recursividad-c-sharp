using System;

namespace Busqueda_Binaria_Recursividad_bucle_while
{
    class Program
    {
        static int Busqueda_Binaria(int [] arreglo, int valorparabuscar, int principio, int fin)
        {
            int mitad= (principio+fin)/2;
            if (principio > fin)
                return -1;
            else
            {
                if (arreglo[mitad] == valorparabuscar)
                    return mitad;
                else
                {
                    if (arreglo[mitad] > valorparabuscar)
                    {
                        return Busqueda_Binaria(arreglo, valorparabuscar, principio, mitad - 1);
                    }
                    else
                    {
                        return Busqueda_Binaria(arreglo, valorparabuscar, mitad + 1, fin);
                    }
                }
            }
        }
        static void Burbuja(int [] arreglo)
        {
            int aux = 0;
            for(int i = 0; i < arreglo.Length; i++)
            {
                for(int j = 0; j < arreglo.Length; j++)
                {
                    if (arreglo[i] < arreglo[j])
                    {
                        aux = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = aux;
                    }
                }
            }
            Console.WriteLine("Este es su arreglo ordenado de menor a mayor");
            for (int z=0; z < arreglo.Length; z++)
            {
                Console.WriteLine(arreglo[z]);
            }
        }
        static void Main(string[] args)
        {
            int ingreso, valorparabuscar;
            Console.WriteLine("Ingrese la longitud de su arreglo");
            ingreso = int.Parse(Console.ReadLine());
            int [] arreglo = new int[ingreso];
            for (int i=0; i<ingreso; i++)
            {
                Console.WriteLine("Ingrese su digito {0}",i+1);
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            Burbuja(arreglo);
            Console.WriteLine("Ingrese el valor que desea buscar de su arreglo");
            valorparabuscar = int.Parse(Console.ReadLine());
            Console.WriteLine(Busqueda_Binaria(arreglo, valorparabuscar, 0, arreglo.Length - 1)); 
        }
    }
}
