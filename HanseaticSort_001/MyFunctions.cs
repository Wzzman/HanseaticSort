using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanseaticSort_001
{
    public class MyFunctions
    {
        public static int smallestElement;
        public static int[] tmpArr;
        public static int[] part1Array;
        public static int[] part2Array;
        public static int[] endArray;
        public static Random rnd1 = new Random();

        public static void PrintMyArray(int[] arr, int smallElement)
        {
            bool isFirstDigitAccepted = false;
            Console.Write("[ ");
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == smallElement && !isFirstDigitAccepted && j == arr.Length / 2) // only one time and if "j" is in center 
                {
                    isFirstDigitAccepted = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(arr[j] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(arr[j] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.Write("]");
        }

        public static void PrintMyArray(int[] arr)
        {
            int size = arr.Length;
            int counter = 0;
            for (int j = 0; j < size - counter; j++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(arr[j] + " ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public static int HelloMessage(int wahl)
        {
            if (wahl == 1)
            {
                Console.WriteLine("Apeman detected!");
            }
            else if (wahl == 2)
            {
                Console.WriteLine("Robot detected!");
            }
            return wahl;
        }

        public static void Aufgabe_1(int[] arr)
        {
            int length = arr.Length;
            int halfLength = length / 2;

            //Array.Sort(arr);
            int tmp = arr[halfLength]; // save like "tmp" digit from center 
            smallestElement = arr[0];
            arr[halfLength] = arr[0];
            arr[0] = tmp;
        }

        public static void FinalArrayErstellen(int[] arr)
        {
            SortMyDigits(arr);
        }

        public static void SortMyDigits(int[] arr)
        {
            int UngerCounter = 0;
            int GerCounter = 0;

            // check a size of ungerade Array
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    UngerCounter++; // how much is the size
                }
                else
                {
                    GerCounter++;
                }
            }

            Console.WriteLine("Size of odd Array is: {0}", UngerCounter);
            Console.WriteLine("Size of even Array is: {0}", GerCounter);
            Console.WriteLine();
            // create 1 part of array

            // 1. Size:
            part1Array = new int[UngerCounter];
            part2Array = new int[GerCounter];

            // 2. Content:
            part1Array = SaveArray1(arr, part1Array);
            Reverser(part1Array);
            part2Array = SaveArray2(arr, part2Array);
            Array.Sort(part2Array);

            // 3. Show it:
            Console.Write("[ ");
            PrintMyArray(part1Array);
            PrintMyArray(part2Array);
            Console.WriteLine("]");
        }

        public static int[] SaveArray1(int[] arr, int[] tmp) // save ungerade array
        {
            int size = arr.Length;
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    tmp[count] = arr[i];
                    count++; // hier kann ein Problem sein
                }
            }
            return tmp;
        }

        public static int[] SaveArray2(int[] arr, int[] tmp) // save gerade array
        {
            int size = arr.Length;
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    tmp[count] = arr[i];
                    count++; // hier kann ein Problem sein
                }
            }
            return tmp;
        }

        public static void Reverser(int[] arr)
        {
            int tmp;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length / 2; i++)
            {
                tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmp;
            }
        }



        //public static void Aufgabe_2(int[] arr)
        //{
        //    //PrintMyArray(arr);
        //    UngeradeDigits(arr);
        //    Console.WriteLine();
        //    GeradeDigits(arr);
        //}

        //public static void UngeradeDigits(int[] arr)
        //{
        //    int counter = 0;
        //    // check a size of ungerade Array
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 1 && arr[i] != smallestElement)
        //        {
        //            counter++; // how much is the size
        //        }
        //    }

        //    //Console.WriteLine("Size of ungerade Array is: {0}", counter);

        //    // create 1 part of array

        //    // 1. Size:
        //    part1Array = new int[counter];
        //    //tmpArr = part1Array;

        //    // 2. Content:
        //    part1Array = SaveNewArray1(arr, part1Array);
        //    Reverser(part1Array);

        //    //PrintMyArray(tmpArr);
        //    //Console.WriteLine();

        //    //// 3. Show it:
        //    //PrintMyArray(part1Array);
        //    //Console.WriteLine();
        //}
        //public static void GeradeDigits(int[] arr)
        //{
        //    int counter = 0;
        //    // check a size of gerade Array
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0 && arr[i] != smallestElement)
        //        {
        //            counter++;
        //        }
        //    }
        //    //Console.WriteLine("Size of gerade Array is: {0}", counter);

        //    // create 2 part of array:
        //    // 1. Size:
        //    part2Array = new int[counter];
        //    // 2. Content:
        //    part2Array = SaveNewArray2(arr, part2Array);
        //    Array.Sort(part2Array);
        //    //Console.WriteLine();
        //    //// 3. Show it:
        //    //PrintMyArray(part2Array);
        //    //Console.WriteLine();
        //}

        //public static int[] SaveNewArray1(int[] arr, int[] tmp) // save ungerade array
        //{
        //    int size = arr.Length;
        //    int count1 = 0;
        //    //if (smallestElement % 2 == 1)
        //    //{
        //    //    size -= 1;
        //    //}

        //    for (int i = 0; i < size; i++)
        //    {
        //                tmp[count1] = arr[i];
        //                count1++;
        //    }
        //    return tmp;
        //}
        //public static int[] SaveNewArray2(int[] arr, int[] tmp) // save gerade array
        //{
        //    int count2 = 0;
        //    int size = arr.Length;
        //    //if (smallestElement % 2 == 0)
        //    //{
        //    //    size -= 1;
        //    //}
        //    for (int i = 0; i < size; i++)
        //    {
        //                tmp[count2] = arr[i];
        //                count2++;
        //    }
        //    return tmp;
        //}
    }
}
