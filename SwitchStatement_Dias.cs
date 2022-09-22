using System;
using System.IO;
using System.Text;

namespace SwitchStatement;

class Program
{
    // Main Method 
    static void Main(string[] args)
    {
        //input the map number
        Console.WriteLine("Jonathas Dias' Copy");
        Console.Write("Enter a number 1-7: ");
        string userChoice = Console.ReadLine();
        string numChoice = "";

        //checking 
        switch (userChoice)
        {
            case "1":
                numChoice = "IT 145";
                break;
            case "2":
                numChoice = "IT 200";
                break;
            case "3":
                numChoice = "IT 201";
                break;
            case "4":
                numChoice = "IT 270";
                break;
            case "5":
                numChoice = "IT 315";
                break;
            case "6":
                numChoice = "IT 328";
                break;
            case "7":
                numChoice = "IT 330";
                break;

            default:
                Console.WriteLine("Invalid Input");
                break;
        }
        //display user input and choice
        Console.WriteLine($"Your choice of {userChoice} is this course {numChoice}");
    }
}