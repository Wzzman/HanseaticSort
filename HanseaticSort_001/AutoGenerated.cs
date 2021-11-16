﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanseaticSort_001
{
    public class AutoGenerated
    {
        public static bool isAutoGenerated = false;
        int tmp;
        Random rnd = new Random();
        public int[] CreateArr()
        {
            isAutoGenerated = true;

            int size = 16/*rndSize.Next(9, 20)*/;
            int[] x = new int[size];

            // i create my array hier
            for (int i = 0; i < size; i++)
            {
                x[i] = GenerateDigit();
            }
            Array.Sort(x);

            // now i will proof my doubles in the array and change it
            for (int i = 0; i < size; i++)
            {                                                                   ////
                if (i > 0 && x[i - 1] == x[i])
                {
                    x[i] = GenerateDigit() + 1;
                }
            }
            Array.Sort(x);

            //MyFunctions.PrintMyArray(x);
            return x;
        }
        public int GenerateDigit()
        {
            tmp = Convert.ToInt32(rnd.Next(100));
            return tmp;
        }
    }
}
