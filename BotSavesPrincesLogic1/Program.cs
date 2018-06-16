using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotSavesPrincesLogic1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Size of array ....................
            int N;
            Console.WriteLine("Enter the size of matrix: in case 3");
            N = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            // we make a grid of size 3 
            // Vector form 
            String[] vector = new String[N];
            // we take input from user until the size of array ( matrix) : the loop runs 3 times
            // because the size of our grid is 3 
            // - - -
            // - m -
            // p - -
            // m stands for bot and p stands for prince 
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the Grid no:" + i);
                vector[i] = Console.ReadLine();
            }
            // Print Grid array
            Console.WriteLine("Print Grid array..............");
            foreach (var vec in vector)
            {
                Console.WriteLine(vec);
            }
            Console.WriteLine("...............................");
            DisplayPathtoPrincess(N, vector);
            Console.WriteLine();
            Console.ReadLine();
        }
        static void DisplayPathtoPrincess(int N, String[] vector)
        {

            int mRow = 0 ;
            int mCol = 0;
            int pRow = 0;
            int pCol = 0;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (vector[row][col] == 'm')
                    {
                        mRow = row;
                        mCol = col;
                    }
                    else if (vector[row][col] == 'p')
                    {
                        pRow = row;
                        pCol = col;
                    }
                }
            }
            
            while (mRow > pRow)
            {
                mRow--;
                Console.WriteLine("UP");    
            }
            while (mRow < pRow)
            {
                mRow++;
                Console.WriteLine("Down");
            }
            while (mCol > pCol)
            {
                mCol--;
                Console.WriteLine("LEFT");
            }
            while (mCol < pCol)
            {
                mCol++;
                Console.WriteLine("RIGHT");
            }




            Console.WriteLine();
        }
    }
}
