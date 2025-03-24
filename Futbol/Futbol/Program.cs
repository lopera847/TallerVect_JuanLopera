using System;

class Program
{
    static void Main()
    {
        // Definir el arreglo bidimensional para 10 equipos y 5 datos cada uno
        // [0] Partidos jugados, [1] Partidos ganados, [2] Puntos, [3] Partidos empatados, [4] Partidos perdidos
        int[,] equipos = new int[10, 5];

        // Leer los datos conocidos para cada equipo
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nDatos del equipo {i + 1}:");

            Console.Write("Partidos jugados: ");
            equipos[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Partidos ganados: ");
            equipos[i, 1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Puntos: ");
            equipos[i, 2] = Convert.ToInt32(Console.ReadLine());

            // Calcular partidos empatados y perdidos
            // Asumimos que cada victoria da 3 puntos y cada empate 1 punto
            int puntosPorVictorias = equipos[i, 1] * 3;
            equipos[i, 3] = equipos[i, 2] - puntosPorVictorias; // Partidos empatados
            equipos[i, 4] = equipos[i, 0] - equipos[i, 1] - equipos[i, 3]; // Partidos perdidos
        }

        // Mostrar los datos completos de todos los equipos
        Console.WriteLine("\nResumen del torneo:");
        Console.WriteLine("Equipo | PJ | PG | PE | PP | Pts");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1,6} | {equipos[i, 0],2} | {equipos[i, 1],2} | {equipos[i, 3],2} | {equipos[i, 4],2} | {equipos[i, 2],3}");
        }
    }
}