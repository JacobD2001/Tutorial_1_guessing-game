using System;

namespace Tutorial_1_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "boar";
            string guess = "";                 //storing variables
            int guesscount = 0;
            int guesslimit = 3;
            bool outofguesses = false;

            while(guess !=secretword && !outofguesses)          //while loop under condition that guess =! secretword && we are not out of guesses
            {
                if (guesscount < guesslimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guesscount++;

                   //f (guess != secretword )           //If guess!=secretword print try again /////////////////////How to print try again only 3 times?
                    //                                 
                     //onsole.WriteLine("Try again");
                    //
                }
                else
                {
                    outofguesses = true;
                }   
            }
            if(outofguesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("Congratulations!! You won");
            }
           









        }
    }
}
