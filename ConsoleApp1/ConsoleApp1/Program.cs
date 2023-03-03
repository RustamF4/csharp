using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void FillArr(int numOfRows, int numOfColumns, int[,] matrix)
        {
            Console.WriteLine("Fill matrix: ");
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }

        static void PrintArr(int numOfRows, int numOfColumns, int[,] matrix)
        {
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void MatrixSum(int numOfRows, int numOfColumns, int[,] matrix1, int[,] matrix2, int[,] sumMatrix)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
        }

        static void MatrixMultiple(int numOfRows, int numOfColumns, int numMult, int[,] matrix2, int[,] multipleMatrix)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    multipleMatrix[i, j] = numMult * matrix2[i, j];
                }
            }
        }

        static void MatrixMultiple( int[,] matrix1, int[,] matrix2, int[,] multipleMatrix)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        multipleMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
        }

        
        static void Main(string[] args)
        {
            link:
            
            Console.WriteLine(" Choose the variant of calculating: \n 1 for Summary \n 2 for multiplying number to matrix \n 3 for multiplying matrix to matrix");
            int n = Int32.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Write the number of rows: ");
                    int numOfRows = Int32.Parse(Console.ReadLine());
            
                    Console.WriteLine("Write the number of columns: ");
                    int numOfColumns = Int32.Parse(Console.ReadLine());
                    
                    int[,] matrix1 = new int[numOfRows, numOfColumns];
                    int[,] matrix2 = new int[numOfRows, numOfColumns];
                    int[,] sumMatrix = new int[numOfRows, numOfColumns];
                    
                    FillArr(numOfRows, numOfColumns, matrix1);
                    FillArr(numOfRows, numOfColumns, matrix2);
            
                    PrintArr(numOfRows, numOfColumns, matrix1);
                    PrintArr(numOfRows, numOfColumns, matrix2);
                    
                    MatrixSum(numOfRows, numOfColumns, matrix1, matrix2, sumMatrix);
                    PrintArr(numOfRows, numOfColumns, sumMatrix);

                    break;
                case 2:
                    Console.WriteLine("Write the number of rows: ");
                    int numOfRows1 = Int32.Parse(Console.ReadLine());
            
                    Console.WriteLine("Write the number of columns: ");
                    int numOfColumns1 = Int32.Parse(Console.ReadLine());
                    
                    Console.Write("Write the multiple number: ");
                    int numMult = Int32.Parse(Console.ReadLine());
                    
                    int[,] multipleMatrix = new int[numOfRows1, numOfColumns1];
                    int[,] matrix11 = new int[numOfRows1, numOfColumns1];
                    int[,] matrix22 = new int[numOfRows1, numOfColumns1];
                    
                    FillArr(numOfRows1, numOfColumns1, matrix22);
                    
                    PrintArr(numOfRows1, numOfColumns1, matrix22);
                    
                    MatrixMultiple(numOfRows1, numOfColumns1, numMult, matrix22, multipleMatrix);
                    PrintArr(numOfRows1, numOfColumns1, multipleMatrix);

                    break;
                case 3:
                    int numOfRows2;
                    int numOfColumns2;
                    int numOfRows22;
                    int numOfColumns22;
                    
                    while (true)
                    {
                        Console.WriteLine("Write the number of rows of first matrix: ");
                        numOfRows2 = Int32.Parse(Console.ReadLine());
            
                        Console.WriteLine("Write the number of columns of first matrix: ");
                         numOfColumns2 = Int32.Parse(Console.ReadLine());
                    
                        Console.WriteLine("Write the number of rows of second matrix: ");
                        numOfRows22 = Int32.Parse(Console.ReadLine());
            
                        Console.WriteLine("Write the number of columns of second matrix: ");
                        numOfColumns22 = Int32.Parse(Console.ReadLine());

                        if (numOfColumns2 == numOfRows22) break;
                        Console.WriteLine("You cant multiple this matrix");
                    }
                    
                    int[,] matrix111 = new int[numOfRows2, numOfColumns2];
                    int[,] matrix222 = new int[numOfRows22, numOfColumns22];
                    int[,] multipleMatrix1 = new int[matrix111.GetLength(0), matrix222.GetLength(1)];
                    
                    FillArr(matrix111.GetLength(0), matrix222.GetLength(1), matrix111);
                    FillArr(matrix111.GetLength(0), matrix222.GetLength(1), matrix222);
                    
                    MatrixMultiple(matrix111, matrix222, multipleMatrix1);
                    
                    PrintArr(matrix111.GetLength(0), matrix222.GetLength(1), multipleMatrix1);
                    
                    break;
                
                default:
                    Console.WriteLine("This option is not available");
                    goto link; // line 72
                    
                    break;
            }
        }
    }
}