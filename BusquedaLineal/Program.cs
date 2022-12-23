using System.Diagnostics;

namespace BusquedaLineal;
class Program
{
    static void Main(string[] args)
    {
        // Inicializar el arreglo con valores aleatorios
        Random random = new Random();
        int[] A = new int[20];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 101);
        }

        Console.WriteLine("ALGORITMO DE BUSQUEDA LINEAL");

        // Imprimir el arreglo desordenado
        Console.WriteLine("Arreglo desordenado");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]},  ");
        }

        // Ingreso de numero a buscar
        Console.Write("\n\nIngrese numero a buscar: ");
        int x = Convert.ToInt32(Console.ReadLine());

        // Busqueda lineal y tiempo de ejecucion de metodo BusquedaLinealID
        DateTime inicio = DateTime.Now;
        int pos = BusquedaLinealID(A, x);
        TimeSpan tiempoTranscurrido = DateTime.Now.Subtract(inicio);

        if (pos == -1)
        {
            Console.WriteLine("\nEl numero no se encuentra en el arreglo");
        }
        else
        {
            Console.WriteLine($"\nEl numero se encuentra en la posicion {pos}");
        }

        Console.WriteLine($"\nTiempo de ejecucion: {tiempoTranscurrido.TotalMilliseconds} ms");
    }

    static int BusquedaLinealID(int[] A, int x)
    {
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
}