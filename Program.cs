using System;

namespace ระบบจำไฟล์
{
    class Program
    {
        static void Main()
        {
            string[] file = new string[5];
            Console.WriteLine("Please input number from 0 - 3 to choose the following menu");
            Console.WriteLine("[0] Show all recent files");
            Console.WriteLine("[1] Open new file");
            Console.WriteLine("[2] Open recent file");
            Console.WriteLine("[3] Exit");

            int choosemenu = int.Parse(Console.ReadLine());
            if(choosemenu == 0)
            {
                Console.Write(file);
                Main();
            }
            if (choosemenu == 1)
            {
                string needfile = Console.ReadLine();
                Main();
            }
            if (choosemenu == 2)
            {
                int sequncefile = int.Parse(Console.ReadLine());
            }
            return;
        }
        
    }
}
