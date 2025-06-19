using System;

class Program
{

    static void escribeZalreves(int[,] M)
    {
        // Asumiendo la matriz es siepre cuadrada
        int counter = 1;

        int rows = M.GetLength(0);
        int columns = M.GetLength(1);

        if (rows != columns)
        {
            throw new ArgumentException("Matrix must be square.");
        }

        int size = rows;

        for (int i = 0; i < 3 * size - 2; i++)
        {
            int row, col;
            if (i < size)
            {
                row = 0;
                col = size - i - 1;
            }
            else if (i < size * 2 - 1)
            {
                row = i - size;
                col = i - size;
            }
            else
            {
                row = size - 1;
                col = 3 * size - 2 - i;
            }
            M[row, col] = counter++;
        }
    }

    static void imprimirvector(int[] V)
    {
        for (int i = 0; i < V.Length; i++)
        {
            Console.Write("{0} ", V[i]);
        }
        Console.WriteLine();
    }

    static void imprimirmatriz(int[,] M)
    {
        int rowLength = M.GetLength(0);
        int columnLength = M.GetLength(1);
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < columnLength; j++)
            {
                Console.Write("{0} ", M[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] vector = new int[100];
        int primernum;
        int posicion;

        rellena_vector(vector, 3, out primernum, out posicion);

        imprimirvector(vector);

        Console.WriteLine("Position: {0}; First prime: {1} ", posicion, primernum);

        int[,] M1 = new int[4, 4];

        escribeZalreves(M1);
        imprimirmatriz(M1);
    }
    static bool rellena_vector(int[] V, int inicio, out int primernum, out int posicion)
    {
        int count = 0;
        primernum = 0;
        posicion = 0;
        while (count < V.Length)
        {
            if (Isprime(inicio))
            {
                V[count] = inicio;
                count++;
            }
            inicio++;
        }
        for (int i = 0; i < V.Length; i++)
        {
            if (V[i] % 5 == 0)
            {
                primernum = V[i];
                posicion = i;
                return true;
            }
        }
        return false;
    }

    static bool Isprime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

}

