﻿using System.ComponentModel;

namespace Ex29AddSubMultMatrix
{
    class Matrix
    {
        // Fields
        int rows, columns;
        int[,] matrix;

        // Constructor
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }

        // Indexer
        public int this[int r, int c]
        {
            get { return matrix[r, c]; }
            set { matrix[r, c] = value; }
        }

        // Operators
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            // Adding of matrices of the same size
            return Operation(m1, m2, true);
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            // Subtracting of matrices of the same size
            return Operation(m1, m2, false);
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            // Multiplying of matrices of the same size
            Matrix m = new Matrix(m1.rows, m1.columns);
            for (int r = 0; r < m.rows; r++)
            {
                for (int c = 0; c < m.columns; c++)
                {
                    for (int k = 0; k < m.columns; k++)
                    {
                        m[r, c] += (dynamic)m1[r, k] * m2[k, c];
                    }
                }
            }
            return m;
        }

        // Method for calcualtion of adding and subtracting
        private static Matrix Operation(Matrix m1, Matrix m2, bool isAdd)
        {
            Matrix m = new Matrix(m1.rows, m1.columns);
            for (int r = 0; r < m.rows; r++)
            {
                for (int c = 0; c < m.columns; c++)
                {
                    // For adding
                    if (isAdd) m[r, c] = (dynamic)m1[r, c] + m2[r, c];

                    // For subtracting
                    else m[r, c] = (dynamic)m1[r, c] - m2[r, c];
                }
            }
            return m;
        }

        // String output for this class
        public override string ToString()
        {
            string result = String.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += String.Format("{0,11:F2}", matrix[i, j]);
                }
                result += "\n";
            }
            return result.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 29
            // Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
            #endregion

            // Creates two matrices with the same size
            int size = 4;
            Matrix matrix1 = new Matrix(size, size);
            Matrix matrix2 = new Matrix(size, size);

            // Generate values for the matrices by random generator
            Random Generator = new Random();
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    matrix1[r, c] = Generator.Next(-10, 10);
                    matrix2[r, c] = Generator.Next(-10, 10);
                }
            }

            // Print the result
            Console.WriteLine("Matrix 1\n" + matrix1);
            Console.WriteLine("Matrix 2\n" + matrix2);
            Console.WriteLine("Matrix 1 + Matrix 2\n" + (matrix1 + matrix2));
            Console.WriteLine("Matrix 1 - Matrix 2\n" + (matrix1 - matrix2));
            Console.WriteLine("Matrix 1 * Matrix 2\n" + (matrix1 * matrix2));
        }
    }
}