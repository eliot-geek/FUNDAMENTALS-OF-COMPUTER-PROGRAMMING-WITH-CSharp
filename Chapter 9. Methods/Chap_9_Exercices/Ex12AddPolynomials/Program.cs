namespace Ex12AddPolynomials
{
    internal class Program
    {
        /// <summary>
        /// Calculates the sum of two polynomials with integer coefficients
        /// </summary>
        /// <param name="poly1"></param>
        /// <param name="poly2"></param>
        /// <returns></returns>
        static int[] AddPolynomials(int[] poly1, int[] poly2)
        {
            int maxLength = Math.Max(poly1.Length, poly2.Length);
            int[] result = new int[maxLength];

            for (int i = 0; i < poly1.Length; i++)
            {
                result[i] += poly1[i];
            }

            for (int i = 0; i < poly2.Length; i++)
            {
                result[i] += poly2[i];
            }
            return result;
        }

        /// <summary>
        /// Print Polynomial
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
            #region Task 12
            /* Write a method that calculates the sum of two polynomials with integer coefficients, for example (3x^2 + x - 3) + (x - 1) = (3x^2 + 2x - 4). 
            Guide: Use arrays to represent the polynomial and the arithmetic rules that you know from math. For example the polynomial (3x^2 + x - 5) 
            can be represented as an array of the numbers {-5, 1, 3}. Bear in mind that it is useful at the zero position to put the coefficient for x0 (in our case -5), 
            at the first position – the coefficient for x1 (in our case 1) and so on.*/
            #endregion

            int[] polynomial1 = { -3, 1, 3 }; // Representing the polynomial 3x^2 + x - 3
            int[] polynomial2 = { -1, 1 };    // Representing the polynomial x - 1
            int[] result = AddPolynomials(polynomial1, polynomial2);
            Console.WriteLine("Resulting polynomial:");
            PrintPolynomial(result);
            Console.ReadLine();
        }
    }
}