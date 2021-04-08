using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace XO_Telos
{
    class XOBoard
    {
        public static List<string> cells = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public static string flag = "O";
        public static int numOfTurns = 0; // starts from 0 to display "None" at the beginning

        // DISPLAY
        public static void Display()
        {
            Console.WriteLine("***  Welcom To Tic-Tac-Toe   ***\n");
            Console.WriteLine("         +===========+  ");
            Console.WriteLine($"         | {cells[1]} | {cells[2]} | {cells[3]} |  ");
            Console.WriteLine("         |---+---+---|  ");
            Console.WriteLine($"         | {cells[4]} | {cells[5]} | {cells[6]} |  ");
            Console.WriteLine("         |---+---+---|  ");
            Console.WriteLine($"         | {cells[7]} | {cells[8]} | {cells[9]} |  ");
            Console.WriteLine("         +===========+  ");
        }

        // STATUS 
        public static string Status(int numOfTurns)
        {
            if (
                 ($"{cells[1]}{cells[2]}{cells[3]}" == $"{flag}{flag}{flag}") ||
                 ($"{cells[4]}{cells[5]}{cells[6]}" == $"{flag}{flag}{flag}") ||
                 ($"{cells[7]}{cells[8]}{cells[9]}" == $"{flag}{flag}{flag}") ||
                 ($"{cells[1]}{cells[4]}{cells[7]}" == $"{flag}{flag}{flag}") ||
                 ($"{cells[2]}{cells[5]}{cells[8]}" == $"{flag}{flag}{flag}") ||
                 ($"{cells[3]}{cells[6]}{cells[9]}" == $"{flag}{flag}{flag}") ||
                 ($"{cells[1]}{cells[5]}{cells[9]}" == $"{flag}{flag}{flag}") ||
                 ($"{cells[3]}{cells[5]}{cells[7]}" == $"{flag}{flag}{flag}")
               )
            {
                return flag;
            }
            else if (numOfTurns < 9)
            {
                return "None";
            }
            else
            {
                return "Draw";
            }
        }

        // PUT
        public static void Put() // put X or O on board
        {
            //switch player
            if (flag == "X")
            {
                flag = "O";
            }
            else if (flag == "O")
            {
                flag = "X";
            }

            Console.Write($"\nPlayer {flag} select cell number from 1 to 9: ");
            string selected = Console.ReadLine();

            while (true)
            {
                if (!selected.All(char.IsDigit)) // is it a number?
                {
                    Console.Write("Must be a number between 1 to 9 :");
                    selected = Console.ReadLine();
                }
                else if (selected == "") // is it blank?
                {
                    Console.Write("Pleas choose a number between 1 to 9 :");
                    selected = Console.ReadLine();
                }
                else if( (Convert.ToInt32(selected) < 1) || (Convert.ToInt32(selected) > 9) ) // is not between 1-9
                {   
                    Console.Write("Only a number between 1 to 9 :");
                    selected = Console.ReadLine();
                }
                else if (cells[Convert.ToInt32(selected)] == "X" || cells[Convert.ToInt32(selected)] == "O") // is it already chosen
                {
                    Console.Write("This cell is already chosen. Select a different cell :");
                    selected = Console.ReadLine();
                }
                else
                {
                    int selectedToInt = Convert.ToInt32(selected); //convert user choose to int
                    cells[selectedToInt] = flag;
                    break;
                }

            }
            Console.Clear();
        }
    }
}

