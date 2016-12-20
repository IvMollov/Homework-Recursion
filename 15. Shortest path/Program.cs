using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Shortest_path
{
    class Program
    {
        static string[,] matrix =
         {
 { "8", "0", "0", "0", "0", "0" },
 { "0", "0", "0", "0", "1", "0" },
 { "0", "1", "1", "1", "1", "0" },
 { "0", "1", "1", "0", "0", "0" },
 { "0", "0", "0", "0", "0", "9" },
 { "0", "0", "1", "0", "0", "0" }
 };
        static int count = 0;
        static string initialCell;
        static void Main()
        {
            Queue<string> visitedCells = new Queue<string>();
            FindStartingCell();
            int row = 0;
            int col = 0;
            string direction = "down";
            visitedCells.Enqueue(initialCell);

            // Perform Breath-First-Search (BFS)
            while (visitedCells.Count > 0)
            {
                string currentCell = visitedCells.Dequeue();

                if (currentCell == "9")
                {
                    PrintMatrix();
                    Console.WriteLine("The shortest way is: {0}\n", count);
                    break;
                }

                if (direction == "right" && (col > matrix.GetLength(1) - 1 || matrix[row, col] != "0"))
                {

                    direction = "down";
                    col--;
                    row++;

                }
                if (direction == "down" && (row > matrix.GetLength(0) - 1 || matrix[row, col] != "0"))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != "0"))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != "0"))
                {

                    direction = "right";
                    row++;
                    col++;
                }

                if (direction == "right")
                {

                    if (matrix[row, col] == "9")
                    {
                        visitedCells.Enqueue(matrix[row, col]);
                    }
                    else
                    {
                        matrix[row, col] = "y";
                        visitedCells.Enqueue(matrix[row, col]);
                        count++;
                    }
                    col++;
                }
                if (direction == "down")
                {

                    if (matrix[row, col] == "9")
                    {
                        visitedCells.Enqueue(matrix[row, col]);
                    }
                    else
                    {
                        matrix[row, col] = "y";
                        visitedCells.Enqueue(matrix[row, col]);
                        count++;
                    }
                    row++;
                }
                if (direction == "left")
                {
                    if (matrix[row, col] == "9")
                    {
                        visitedCells.Enqueue(matrix[row, col]);
                    }
                    else
                    {
                        visitedCells.Enqueue(matrix[row, col]);
                        count++;
                    }
                    col--;
                }
                if (direction == "up")
                {

                    if (matrix[row, col] == "9")
                    {
                        visitedCells.Enqueue(matrix[row, col]);
                    }
                    else
                    {
                        matrix[row, col] = "y";
                        visitedCells.Enqueue(matrix[row, col]);
                        count++;
                    }
                    row--;
                }
            }

        }
        static void FindStartingCell()
        {
            for (int i = 0; i < matrix.GetLongLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLongLength(1); j++)
                {
                    if (matrix[i, j] == "8")
                    {
                        initialCell = matrix[i, j];
                        return;
                    }
                }
            }

            throw new Exception("Start cell is missing -> no path...\n");
        }

        static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLongLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLongLength(1); j++)
                    Console.Write("{0,3}", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
