namespace Ex13MultiPolynomials
{
    internal class Program
    {
        /// <summary>
        /// Multiply Polynomials
        /// </summary>
        /// <param name="poly1"></param>
        /// <param name="poly2"></param>
        /// <returns></returns>
        static int[] MultiplyPolynomials(int[] poly1, int[] poly2)
        {
            int resultLength = poly1.Length + poly2.Length - 1;
            int[] result = new int[resultLength];

            for (int i = 0; i < poly1.Length; i++)
            {
                for (int j = 0; j < poly2.Length; j++)
                {
                    result[i + j] += poly1[i] * poly2[j];
                }
            }
            return result;
        }

        /// <summary>
        /// Print Polyonomial
        /// </summary>
        /// <param name="polynomial"></param>
        static void PrintPolynomial(int[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0)
                {
                    string term = (i > 0) ? $" + {polynomial[i]}x^{i}" : $" + {polynomial[i]}";
                    Console.Write(term);
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Task 13
            /* Write a method that calculates the product of two polynomials with integer coefficients, for example (3x2 + x - 3) * (x - 1) = (3x3 - 2x2 - 4x + 3). 
            Guide: Use the instructions from the previous task and the rules for polynomial multiplication that you know from math. 
            How to multiple polynomials can be read here: http://www.purplemath.com/modules/polymult.htm.*/
            #endregion

            int[] polynomial1 = { -3, 1, 3 }; // Representing the polynomial 3x^2 + x - 3
            int[] polynomial2 = { -1, 1 };    // Representing the polynomial x - 1
            int[] result = MultiplyPolynomials(polynomial1, polynomial2);
            Console.WriteLine("Resulting polynomial:");
            PrintPolynomial(result);
            Console.ReadLine();
        }
    }
}