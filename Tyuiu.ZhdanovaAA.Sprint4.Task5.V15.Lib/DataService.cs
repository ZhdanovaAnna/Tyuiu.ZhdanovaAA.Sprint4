﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhdanovaAA.Sprint4.Task5.V15.Lib
{
    public class DataService : ISprint4Task5V15
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            int s = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        s += matrix[i, j];
                    }
                }
            }
            return s;
        }
    }
}
