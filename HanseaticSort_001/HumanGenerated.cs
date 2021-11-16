using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HanseaticSort_001
{
    public class HumanGenerated
    {
        public static bool isHumanGenerated = false;
        public static Regex regex = new Regex(@"^\d+$"); /*"^\d$"*/ // for a one number
        public static int size;
        public static string sizeBevor;
        public static int maxsize = 50;
        public static bool inOrdnung = false;

        public static int ProofDigit()
        {
            try
            {
                Console.WriteLine("Input the arrays length like a digit from 1 to {0} please: ", maxsize);
                sizeBevor = Console.ReadLine();
                Console.WriteLine(sizeBevor);
                if (regex.IsMatch(sizeBevor))
                {
                    Console.WriteLine("Its a digit, OK!");
                    if (Convert.ToInt32(sizeBevor) < 1 || Convert.ToInt32(sizeBevor) > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ops, the size must be: 1. Be a digit and 2. be LARGE of 1 and NO LARGE of {0}. So, please repit it correct...", maxsize);
                        Console.ResetColor();
                        return ProofDigit();
                    }
                    else
                    {
                        size = Convert.ToInt32(sizeBevor);
                        Console.WriteLine(size);
                        return size;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, its not a digit. Please try it again...");
                    return ProofDigit();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Tooooo much, my friend. NOT large 50 please!");
                return ProofDigit();
            }
        }

        public int[] CreateArr()
        {
            size = ProofDigit();
            isHumanGenerated = true;
            int[] x = new int[size];
            for (int i = 0; i < size; i++)
            {
                try
                {
                    Console.WriteLine("Input {0} digit please: ", i + 1);
                    x[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("A digit, please...");
                    x[i] = Convert.ToInt32(Console.ReadLine());
                    //throw;
                }
            }
            Array.Sort(x);
            return x;
        }
    }
}
