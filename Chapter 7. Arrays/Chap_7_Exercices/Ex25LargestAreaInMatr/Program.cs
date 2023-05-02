namespace Ex25LargestAreaInMatr
{
    internal class Program
    {
        // Define private variables for the matrix, visited cells, number of rows and columns,
        // maximum count of cells in an area, and the current count of cells in the current area.
        private static int[,] matrix;
        private static bool[,] visited;
        private static int rows;
        private static int cols;
        private static int maxCount;
        private static int currentCount;

        /// <summary>
        /// This method reads the dimensions of the matrix and the matrix elements from the console
        /// </summary>
        private static void ReadMatrix()
        {
            // Prompt user to enter number of rows
            Console.Write("Enter number of rows: ");
            // Read number of rows entered by user and store in "rows"
            rows = int.Parse(Console.ReadLine());
            // Prompt user to enter number of columns
            Console.Write("Enter number of columns: ");
            // Read number of columns entered by user and store in "cols"
            cols = int.Parse(Console.ReadLine());

            // Create a 2D integer array called "matrix" with the specified number of rows and columns
            matrix = new int[rows, cols];
            // Create a 2D boolean array called "visited" with the specified number of rows and columns
            visited = new bool[rows, cols];

            Console.WriteLine("Enter the matrix:");
            // Iterate over each row and column of the matrix and store the elements in "matrix"
            for (int row = 0; row < rows; row++)
            {
                // Read a line of input from the console and split it into an array of strings
                string[] inputLine = Console.ReadLine().Split();
                // Iterate over each element in the current row of the matrix and store it in "matrix"
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(inputLine[col]);
                }
            }
        }

        /// <summary>
        /// performs a depth-first search (DFS) traversal starting from a given cell (specified by its row and column indices) in a 2D matrix. 
        /// It marks visited cells and increments a counter for each cell with a specific value, stopping when it encounters cells that are out of bounds or have different values. 
        /// This process effectively computes the size of the connected region of cells with the same value that contains the starting cell.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        private static void TraverseAreaDFS(int row, int col, int value)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                // Check if the current cell is out of the matrix bounds
                // out of bounds
                return;
            }

            if (visited[row, col] || matrix[row, col] != value)
            {
                // Check if the current cell has already been visited or has a different value than the starting cell.
                // already visited or different value
                return;
            }

            // Mark the current cell as visited and increase the current count of cells.
            visited[row, col] = true;
            currentCount++;

            // Recursively traverse the neighboring cells in all four directions
            TraverseAreaDFS(row - 1, col, value); // up
            TraverseAreaDFS(row + 1, col, value); // down
            TraverseAreaDFS(row, col - 1, value); // left
            TraverseAreaDFS(row, col + 1, value); // right
        }

        /// <summary>
        /// Find the largest area
        /// </summary>
        private static void FindLargestArea()
        {
            // Initializes maxCount to 0
            maxCount = 0;

            // Iterates over each cell of the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // If the cell hasn't been visited yet, traverses the area
                    if (!visited[row, col])
                    {
                        currentCount = 0;
                        TraverseAreaDFS(row, col, matrix[row, col]);
                        // If the current area count is greater than the maxCount, updates it
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                        }
                    }
                }
            }
            // Prints the size of the largest area of equal numbers
            Console.WriteLine("The largest area of equal numbers has {0} elements.", maxCount);
            Console.WriteLine("The largest area of equal numbers has a size of {0}.", maxCount);
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

            ReadMatrix();
            FindLargestArea();
            Console.ReadKey();
        }
    }
}