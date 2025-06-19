using System;

class Program
{
    static void Main()
    {
        int out1int;
        int out2int;

        char[,] myMatrix = new char[9, 5];
        rellenar(myMatrix);

        int rows = myMatrix.GetLength(0);
        int columns = myMatrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0}", myMatrix[i, j]);
            }
            Console.WriteLine();
        }

        do
        {
            Console.WriteLine("Enter the first number, bigger than 0: ");
            string out1 = Console.ReadLine();
            out1int = int.Parse(out1);

            Console.WriteLine("Enter the second number, bigger than 0 and bigger than the first number: ");
            string out2 = Console.ReadLine();
            out2int = int.Parse(out2);

        } while (out1int <= 0 || out2int <= 0 || out1int >= out2int);

        int sum;
        int prod;

        bool primeInInterval = PrimeInterval(out1int, out2int, out sum, out prod);

        if (primeInInterval)
        {
            Console.WriteLine("There is/are prime number(s) in the inteval, their sum is {0}, their product is {1}.", sum, prod);
        }
        else
        {
            Console.WriteLine("There are no primes in the interval");
        }

        int testSum;
        int testProd;

        bool testResult = PrimeInterval(10, 20, out testSum, out testProd);

        int[] equation1 = new int[] { 4, 3, -1, 5 };
        int[] equation2 = new int[] { 7, -2, 15, 26 };
        int[] equation3 = new int[] { 61, -4, 3, 12 };
        int[] equation4 = new int[] { 3, 6, -3, 4 };
        int[] equation5 = new int[] { 2, -3, 5, 6 };
        int[] equation6 = new int[] { 6, -4, 6, 21 };

        double resultX1, resultX2, resultY1, resultY2, resultZ1, resultZ2;


        ThreeEquations(equation1, equation2, equation3, out resultX1, out resultY1, out resultZ1);

        Console.WriteLine("The result of the first system of equations: x = {0}; y = {1}; z = {2}", resultX1, resultY1, resultZ1);

        ThreeEquations(equation4, equation5, equation6, out resultX2, out resultY2, out resultZ2);

        Console.WriteLine("The result of the second system of equations: x = {0}; y = {1}; z = {2}", resultX2, resultY2, resultZ2);

    }

    static bool MatrixToTwoVectors(char[,] initialMatrix, out char[] vectorResult1, out char[] vectorResult2)
    {
        int rows = initialMatrix.GetLength(0);
        int columns = initialMatrix.GetLength(1);

        int midrow = rows / 2;
        int midcol = columns / 2;

        vectorResult1 = new char[rows];
        vectorResult2 = new char[columns];

        if (rows % 2 == 0 || columns % 2 == 0)
        {
            return false;
        }

        for (int i = 0; i < columns; i++)
        {
            vectorResult1[i] = initialMatrix[midrow, i];
        }

        for (int i = 0; i < rows; i++)
        {
            vectorResult2[i] = initialMatrix[i, midcol];
        }
        return true;
    }

    static void MatrixToVector(char[,] matriz, out char[] vectorResult)
    {
        int rows = matriz.GetLength(0);
        int columns = matriz.GetLength(1);
        vectorResult = new char[rows * columns];

        int count = 0;

        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = columns - 1; j >= 0; j--)
            {
                vectorResult[count] = matriz[i, j];
                count++;
            }
        }
    }

    static bool PrimeInterval(int intervalStart, int intervalEnd, out int sum, out int product)
    {
        sum = 0;
        product = 1;

        bool result = false;

        for (int i = intervalStart; i <= intervalEnd; i++)
        {
            if (isPrime(i))
            {
                result = true;
                sum += i;
                product *= i;
            }
        }

        if (!result)
        {
            product = 0;
        }

        return result;
    }


    static bool isPrime(int a)
    {
        if (a <= 1) return false;

        for (int i = 2; i < a; i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }


    static void ThreeEquations(int[] equation1, int[] equation2, int[] equation3, out double resultX, out double resultY, out double resultZ)
    {
        resultX = 1;
        resultY = 1;
        resultZ = 1;
    }

    static void rellenar(char[,] M)
    {
        Random r = new Random();
        for (int i = 0; i < M.GetLength(0); i++)
            for (int j = 0; j < M.GetLength(1); j++)
            {
                M[i, j] = (char)r.Next(65, 90);
            }
    }

    // Este método imprime en pantalla una matriz de tamaño cualquiera fila a fila.
    static void imprime(char[,] M)
    {
        for (int i = 0; i < M.GetLength(0); i++)
        {
            for (int j = 0; j < M.GetLength(1); j++)
            {
                Console.Write("{0} ", M[i, j]);
            }
            Console.WriteLine();
        }
    }

    //Este método imprime un vector de tamaño cualquiera en pantalla.
    static void muestraVector(char[] V)
    {
        for (int i = 0; i < V.Length; i++)
        {
            Console.Write("{0} ", V[i]);
        }
    }

}