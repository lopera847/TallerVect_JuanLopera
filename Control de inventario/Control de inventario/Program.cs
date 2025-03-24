using System;

class Program
{
    static void Main()
    {
        // Definir los arreglos
        int[] A = new int[17];
        int[] B = new int[17];
        int[] C = new int[17];
        
        // Leer los datos del inventario (vector A)
        Console.WriteLine("Ingrese las existencias actuales de los 17 productos:");
        for (int i = 0; i < 17; i++)
        {
            Console.Write($"Producto {i + 1}: ");
            A[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        // Leer los pedidos de clientes (vector B)
        Console.WriteLine("\nIngrese los pedidos de los clientes para los 17 productos:");
        for (int i = 0; i < 17; i++)
        {
            Console.Write($"Producto {i + 1}: ");
            B[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        // Calcular el vector C según las reglas
        for (int i = 0; i < 17; i++)
        {
            if (A[i] == B[i])
            {
                C[i] = A[i];
            }
            else if (B[i] > A[i])
            {
                C[i] = 2 * (B[i] - A[i]);
            }
            else // A[i] > B[i]
            {
                C[i] = B[i];
            }
        }
        
        // Mostrar los resultados
        Console.WriteLine("\nResultados (lo que se requiere comprar):");
        for (int i = 0; i < 17; i++)
        {
            Console.WriteLine($"Producto {i + 1}: {C[i]}");
        }
    }
}