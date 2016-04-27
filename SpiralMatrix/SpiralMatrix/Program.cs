using System;

class SpiralMatrix
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint number = 1;
        uint[,] matrix = new uint[N, N];
        byte direction = 0; //0-right, 1-down, 2-left, 3-right
        int i = 0, j = 0;
        for (uint k = 1; k <= N * N; k++)
        {
            matrix[i, j] = k;
            if (direction == 0)//right
            {
                if (j + 1 >= N)
                {
                    direction = 1;
                    i++;
                }
                else if (matrix[i, j + 1] != 0)
                {
                    direction = 1;
                    i++;
                }
                else
                {
                    j++;
                }
            }
            else if (direction == 1)//down
            {
                if (i + 1 >= N)
                {
                    direction = 2;
                    j--;
                }
                else if (matrix[i + 1, j] != 0)
                {
                    direction = 2;
                    j--;
                }
                else
                {
                    i++;
                }
            }
            else if (direction == 2)//left
            {
                if (j - 1 < 0)
                {
                    direction = 3;
                    i--;
                }
                else if (matrix[i, j - 1] != 0)
                {
                    direction = 3;
                    i--;
                }
                else
                {
                    j--;
                }
            }
            else if (direction == 3)//up
            {
                if (i - 1 < 0)
                {
                    direction = 0;
                    j++;
                }
                else if (matrix[i - 1, j] != 0)
                {
                    direction = 0;
                    j++;
                }
                else
                {
                    i--;
                }
            }
        }
        for (int k = 0; k < N; k++)
        {
            for (int t = 0; t < N; t++)
            {
                Console.Write("{0} ", matrix[k, t]);
            }
            Console.WriteLine();
        }
    }
}