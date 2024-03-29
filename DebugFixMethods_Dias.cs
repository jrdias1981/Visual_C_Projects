﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }


        void run()
        {
            int choice = 0;

            WritePrompt(); //capitalized 'P' to match method
            choice = ReadChoice();
            WriteChoice(choice);

        }

        void WritePrompt()
        {
            Console.WriteLine("Jonathas Dias' Copy");//added per rubric requirement
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        int ReadChoice()
        {
            string s = "";
            s = Console.ReadLine();
            return (Int32.Parse(s));//needed to convert 's' from string to int
        }
        
        void WriteChoice(int choice) //added 'int' to validate method
        {
            Console.WriteLine("Your choice is " + choice);
        }

    }
}
