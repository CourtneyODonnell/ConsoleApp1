using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //making an array and by default providing 0-9 where no use of zero
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //default player 1 is set
        static int choice; //holds the choice of user
        static int flag = 0;  //flag value set to 0
        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); //whenever loop will be again start then screen will be clear
                Console.WriteLine("Player1: X and Player2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0) //checking the chance of the player
                { Console.WriteLine("Player 2 Choice");                }
                else
                { Console.WriteLine("Player 1 Choice");                }
                Console.WriteLine("\n");
                Board(); // calling the board Function
                choice = int.Parse(Console.ReadLine()); // Takes user choice
                // checking that position where user want to run is not already filled
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chanxe is of player 2 then mark O, else mark X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else //If there is any possition where user want to run and that is already filled then show message and load board again
                {
                    Console.WriteLine("Sorry the row {0} is already marked with an {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
        }
    }
}
