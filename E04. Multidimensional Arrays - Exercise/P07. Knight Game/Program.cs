using System;
using System.Linq;

namespace P07._Knight_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixProperties = int.Parse(Console.ReadLine());
            int rows = matrixProperties;
            int columns = matrixProperties;
            if (matrixProperties < 3)
            {
                Console.WriteLine(0);
                return;
            }

            char[,] matrix = new char[rows, rows];
            for (int row = 0; row < rows; row++)
            {
                string symbols = Console.ReadLine();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            int knightsRemoved = 0;
            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, col);
                            if (countMostAttacking < attackedKnights)
                            {
                                countMostAttacking = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }
                        }
                    }
                }
                if (countMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                    knightsRemoved++;
                }
            }

            Console.WriteLine(knightsRemoved);

            int CountAttackedKnights(int row, int col)
            {
                int attackedKnights = 0;

                //horizontal left-up
                if (IsCellValid(row - 1, col - 2))
                {
                    if (matrix[row - 1, col - 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal left-down
                if (IsCellValid(row + 1, col - 2))
                {
                    if (matrix[row + 1, col - 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal right-up
                if (IsCellValid(row - 1, col + 2))
                {
                    if (matrix[row - 1, col + 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //horizontal right-down
                if (IsCellValid(row + 1, col + 2))
                {
                    if (matrix[row + 1, col + 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //vertical up-left
                if (IsCellValid(row - 2, col - 1))
                {
                    if (matrix[row - 2, col - 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //vertical up-right
                if (IsCellValid(row - 2, col + 1))
                {
                    if (matrix[row - 2, col + 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //vertical down-left
                if (IsCellValid(row + 2, col - 1))
                {
                    if (matrix[row + 2, col - 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //vertical down-right
                if (IsCellValid(row + 2, col + 1))
                {
                    if (matrix[row + 2, col + 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                return attackedKnights;
            }

            bool IsCellValid(int row, int col)
            {
                return
                    row >= 0
                    && row < matrixProperties
                    && col >= 0
                    && col < matrixProperties;
            }
        }
    }
}
