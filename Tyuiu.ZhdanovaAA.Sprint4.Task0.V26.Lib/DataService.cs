﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhdanovaAA.Sprint4.Task0.V26.Lib
{
    public class DataService : ISprint4Task0V26
    {
        public int GetSumOddArrEl(int[] array)
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    s += array[i];
                }
            }
            return s;
        }
    }
}
