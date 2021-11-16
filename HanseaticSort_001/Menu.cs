using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanseaticSort_001
{
    public class Menu
    {
        public static int ProgramMenu()
        {
            int answer;
            Console.Write("Möchten Sie selbst ein Array erstellen? ");
            Console.Write("[y/N]");
            answer = Console.ReadLine() == "y" ? 1 : 2;
            return answer;
        }

    }
}
