using System;

class Program
{
    static void Main()
    {
        // Definir los arreglos
        double[] arreglo1 = new double[7];
        double[] arreglo2 = new double[7];
        double[] arreglo3 = new double[7];

        // Leer los datos del usuario
        Console.WriteLine("Ingrese los 7 números para el primer arreglo:");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Número {i + 1}: ");
            arreglo1[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nIngrese los 7 números para el segundo arreglo:");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Número {i + 1}: ");
            arreglo2[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calcular la diferencia y sumar para el promedio
        double suma = 0;
        for (int i = 0; i < 7; i++)
        {
            arreglo3[i] = arreglo1[i] - arreglo2[i];
            suma += arreglo3[i];
        }

        // Calcular y mostrar el promedio
        double promedio = suma / 7;
        Console.WriteLine($"\nEl promedio de los datos del tercer arreglo es: {promedio:F2}");

        // Mostrar los datos del tercer arreglo
        Console.WriteLine("\nDatos del tercer arreglo (diferencia):");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Posición {i}: {arreglo3[i]}");
        }
    }
}