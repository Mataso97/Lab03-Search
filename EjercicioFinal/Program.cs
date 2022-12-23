namespace BusquedaSecuencial;
class Program
{
    static void Main(string[] args)
    {
        int exitos = 0, fallos = 0;
        // Inicializar el arreglo con valores aleatorios
        Random random = new Random();
        int[] A = new int[100];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 201);
        }

        // Imprimir el arreglo desordenado
        Console.WriteLine("\nArreglo desordenado");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"{A[i]} ");
        }
        Console.WriteLine();

        // Generar array de 50 numeros aleatorios a ser buscados
        int[] B = new int[50];
        for (int i = 0; i < B.Length; i++)
        {
            B[i] = random.Next(1, 201);
            if (BusquedaSecuencial(A, B[i]) == true)
            {
                exitos = exitos + 1;
            }
            else
            {
                fallos++;
            }
        }

        // Busquedas exitosas y fallidas
        Console.WriteLine("\n\nBusquedas Exitosas: {0}", exitos);
        Console.WriteLine("Busquedas Fallidas: {0}", fallos);

        // Porcentaje de exitos y fallos
        Console.WriteLine("\nEl porcentaje de exitos es: {0}%", (exitos * 100) / 50);
        Console.WriteLine("El porcentaje de fallos es: {0}%", (fallos * 100) / 50);

        // Imprimir el arreglo ordenado creciente
        Quicksort(A, 0, A.Length - 1);
        Console.WriteLine("\nArreglo ordenado creciente");
        for (int j = 0; j < A.Length; j++)
        {
            Console.Write(A[j] + " ");
        }
        Console.WriteLine();
        
    }

    static Boolean BusquedaSecuencial(int[] A, int x)
    {
        int i = 0;
        while (i < A.Length && A[i] != x)
        {
            i++;
        }
        if (i < A.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Quicksort(int[] A, int primero, int ultimo)
    {
        int i, j, central, pivote;
        central = (primero + ultimo) / 2;
        pivote = A[central];
        i = primero;
        j = ultimo;
        do
        {
            while (A[i] < pivote)
            {
                i++;
            }
            while (A[j] > pivote)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
        {
            Quicksort(A, primero, j);
        }
        if (i < ultimo)
        {
            Quicksort(A, i, ultimo);
        }
    }
}
