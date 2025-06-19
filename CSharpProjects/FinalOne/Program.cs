
using System;

class Program
{
    static void Main()
    {

        // Anexo I. Testing 1

        int value;

        Console.WriteLine("Please enter a number: ");
        string input = Console.ReadLine();
        bool success = int.TryParse(input, out value);

        if (!success)
        {
            throw new ArgumentException("Please provide a valid input");
        }

        int rootCount;

        bool rootResult = Raizn(value, 78125, out rootCount);

        if (rootResult)
        {
            Console.WriteLine("TRUE. The number you provided is the root of 78125. It's count is {0}", rootCount);
        }
        else
        {
            Console.WriteLine("FALSE. The number you provided is not the root of 78125.");
        }

        // Anexo 1. Testing 2
        Console.WriteLine("Enter the start of the interval: ");
        int value1;
        string input1 = Console.ReadLine();
        bool success1 = int.TryParse(input1, out value1);

        Console.WriteLine("Enter the end of the interval: ");
        int value2;
        string input2 = Console.ReadLine();
        bool success2 = int.TryParse(input2, out value2);

        if (!success1 || !success2)
        {
            throw new ArgumentException("Please provide a valid number");
        }

        int divisoresResult1;
        int divisoresResult2;

        Divisores(20, 30, value1, value2, out divisoresResult1);
        Divisores(120, 140, value1, value2, out divisoresResult2);

        Console.WriteLine("In the interval [{0};{1}] there are {2} divisors of 20 and 30.", value1, value2, divisoresResult1);
        Console.WriteLine("In the interval [{0};{1}] there are {2} divisors of 120 and 140.", value1, value2, divisoresResult2);

        // Anexo II. Testing 1

        int[,] M1 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        int ncol;

        Console.WriteLine("Please enter a column number: ");
        string input3 = Console.ReadLine();

        bool success3 = int.TryParse(input3, out ncol);

        while (!success3)
        {
            Console.WriteLine("Please enter a valid column number: ");
            input3 = Console.ReadLine();
            success3 = int.TryParse(input3, out ncol);
        }

        if (ncol >= 0 && ncol < 4)
        {
            int count;
            int[] V1 = Submatrix(M1, ncol, out count);
            muestraMatriz(M1);
            muestraVector(V1);
            Console.WriteLine("Copied {0} elements.", count);
        }
        else
        {
            throw new ArgumentException("Número de columna incorrecto");
        }

        int[,] M2 = new int[,] { { 1, 2, 3 }, { 5, 6, 12 }, { 9, 10, 11 } };

        int[,] M3 = new int[,] { { 7, 3, 6 }, { 8, 1, 4 }, { 6, 5, 13 } };

        int[,] M4 = new int[3, 3];

        bool result = Mezcla(M2, M3, out M4);

        if (result)
        {
            muestraMatriz(M2);
            Console.WriteLine();
            muestraMatriz(M3);
            Console.WriteLine();
            muestraMatriz(M4);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No se pudo obtener la matriz");
        }

    }


    static bool Mezcla(int[,] matrix1, int[,] matrix2, out int[,] resultMatrix)
    {
        int matrix1rows = matrix1.GetLength(0);
        int matrix1columns = matrix1.GetLength(1);
        int matrix2rows = matrix2.GetLength(0);
        int matrix2columns = matrix2.GetLength(1);

        resultMatrix = new int[0, 0];

        if ((matrix1rows != matrix2rows) || (matrix1columns != matrix2columns) || (matrix1rows != matrix1columns) || (matrix2rows != matrix2columns))
        {
            return false;
        }

        resultMatrix = new int[matrix1rows, matrix1columns];

        for (int i = 0; i < matrix1rows; i++)
        {
            for (int j = 0; j < matrix1columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[j, i];
            }
        }
        return true;
    }

    static int[] Submatrix(int[,] matrixInput, int column, out int count)
    {
        int rows = matrixInput.GetLength(0);
        int columns = matrixInput.GetLength(1);

        int[] resultingVector = new int[(columns - column) * (rows)];
        count = 0;

        for (int i = column; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                resultingVector[count] = matrixInput[j, i];
                count++;
            }
        }

        return resultingVector;
    }

    static bool Raizn(int num1, int num2, out int count)
    {
        int starting = num1;
        count = 0;
        while (num1 < num2)
        {
            if (num1 * starting == num2)
            {
                count++;
                return true;
            }
            num1 *= starting;
            count++;
        }
        return false;
    }

    static void Divisores(int a, int b, int c, int d, out int result)
    {
        if (c > d)
        {
            throw new ArgumentException("c must be smaller than d");
        }

        result = 0;

        for (int i = c; i <= d; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                result++;
            }
        }
    }

    static void VariosDiv(int a, int b, int c, int d, int e, int f, out int num1, out int num2)
    {
        if (c > d || e > f)
        {
            throw new ArgumentException("c must be smaller than d and e must be smaller than f");
        }

        Divisores(a, b, c, d, out num1);
        Divisores(a, b, e, f, out num2);
    }

    //Este método imprime un vector de enteros de tamaño cualquiera
    static void muestraVector(int[] V)
    {
        for (int i = 0; i < V.Length; i++)
        {
            Console.Write("{0} ", V[i]);
        }
        Console.WriteLine();
    }
    //Este método imprime una matriz de enteros de tamaño cualquiera
    static void muestraMatriz(int[,] M)
    {
        for (int i = 0; i < M.GetLength(0); i++)
        {
            for (int j = 0; j < M.GetLength(1); j++)
            {
                Console.Write("{0} ", M[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}