using System;

namespace Ex25LargestAreaOfEqualNum
{
    class Program
    {
        static int n;                   // number of rows in the matrix
        static int m;                   // number of columns in the matrix
        static int[,] matrix;           // 2D array that holds the elements of the matrix
        static bool[,] visited;         // 2D boolean array that keeps track of the visited cells during DFS (Depth-First-Search)
        static int maxAreaSize = 0;     // an integer that holds the size of the largest area of equal numbers found so far

        /// <summary>
        /// This method reads the dimensions of the matrix (number of rows and columns) from the user input
        /// </summary>
        static void ReadMatrix()
        {
            // Prompt the user to enter the number of rows
            Console.Write("Enter number of rows: ");
            // Read the number of rows from the console input and parse it to an integer
            n = int.Parse(Console.ReadLine());
            // Prompt the user to enter the number of columns
            Console.Write("Enter number of columns: ");
            // Read the number of columns from the console input and parse it to an integer
            m = int.Parse(Console.ReadLine());

            // Initialize the matrix with n rows and m columns
            matrix = new int[n, m];
            // Initialize the visited array with n rows and m columns
            visited = new bool[n, m];

            // Prompt the user to enter the matrix
            Console.WriteLine("Enter matrix:");
            // Iterate over each row in the matrix
            for (int row = 0; row < n; row++)
            {
                // Read a line of input from the console and split it into an array of cells
                string[] cells = Console.ReadLine().Split(' ');
                // Iterate over each column in the matrix
                for (int col = 0; col < m; col++)
                {
                    // Parse the cell string to an integer and assign it to the corresponding matrix element
                    matrix[row, col] = int.Parse(cells[col]);
                }
            }
        }

        /// <summary>
        /// Searches for the largest area of equal numbers in the matrix by iterating over each cell in the matrix and checking if it has been visited before. 
        /// If the cell has not been visited before, the method calls the DFS method to traverse the area of the matrix containing the same number as the starting cell. 
        /// The size of the area is then compared with the largest area found so far (maxAreaSize) and updated if the newly found area is larger.
        /// </summary>
        static void FindLargestArea()
        {
            // Loop through each cell of the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    // If the cell has not been visited yet
                    if (!visited[row, col])
                    {
                        // Use DFS to find the size of the area starting from this cell
                        int areaSize = DFS(row, col);

                        // If the area size is greater than the current maximum area size,
                        // update the maximum area size
                        if (areaSize > maxAreaSize)
                        {
                            maxAreaSize = areaSize;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method uses DFS algorithm to traverse the matrix and find the size of an area starting from the specified row and column position.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        static int DFS(int row, int col)
        {
            // Mark the current position as visited
            visited[row, col] = true;

            // Define the movement directions.
            int[] dRow = { -1, 0, 1, 0 };
            int[] dCol = { 0, 1, 0, -1 };

            // Initialize the area size to 1 (the current cell).
            int areaSize = 1;

            // Iterate over the four movement directions.
            for (int dir = 0; dir < 4; dir++)
            {
                // Calculate the position of the next cell
                int newRow = row + dRow[dir];
                int newCol = col + dCol[dir];

                // Check if the next cell is out of bounds
                if (newRow < 0 || newRow >= n || newCol < 0 || newCol >= m)
                {
                    // Continue to the next direction if the cell is out of bounds.
                    continue;
                }

                // Check if the next cell has already been visited or has a different value than the current cell.
                if (visited[newRow, newCol] || matrix[newRow, newCol] != matrix[row, col])
                {
                    // Continue to the next direction if the cell has already been visited or has a different value.
                    continue;
                }
                // Recursively traverse the next cell and add the size of its area to the current area size.
                areaSize += DFS(newRow, newCol);
            }
            // Return the area size
            return areaSize;
        }

        static void Main(string[] args)
        {
            #region Task 25
            /* Write a program, which finds in a given matrix the largest area of equal numbers. We define an area in the matrix as a set of neighbor cells 
            (by row and column). Here is one example with an area containing 13 elements with equal value of 3: 
            
            1  3  2  2  2  4
            3  3  3  2  4  4 
            4  3  1  2  3  3    ====> 13
            4  3  1  3  3  1
            4  3  3  3  1  1

            Guide: This is a little bit more difficult. You can use different graph traversal algorithms like "DFS" (Depth-First-Search) and "BFS" 
            (Breadth-First-Search) to go through all the cells in certain area starting from any cell that belongs to it. If you have an area traversal 
            algorithm (like DFS), run it several times starting from unvisited cell and mark the cells of the traversed area as visited. Repeat this until 
            all cells become visited. Read later in this book about DFS and BFS in the chapter “Trees and Graphs” or find information about these algorithms 
            in Internet. */
            #endregion

            Console.WriteLine("Write a program, which finds in a given matrix the largest area of equal numbers");
            // Reads the matrix from user input and initializes the "matrix" and "visited" arrays
            ReadMatrix();
            // Traverses the matrix to find the largest area of equal adjacent elements using DFS algorithm
            FindLargestArea();
            // Prints the largest area size found in the matrix to the console
            Console.WriteLine("Largest area size: {0}", maxAreaSize);
        }
    }
}
