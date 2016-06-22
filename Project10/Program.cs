using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project 10
// Date: 04/09/2016 09:15:19 pm
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project10
{
    class Program
    {
        //Declare a onstant
        const int
            THREEHUNDRED = 300,
            TEN = 10,
            ONE = 1,
            ZERO = 0;
            

        static void Main(string[] args)
        {
            //Create an object for the class
            BowlingTeam bt = new BowlingTeam();

            //Declare a string
            string userInput;

            //Declare two arrays
            string[] name;
            int[] score;

            //Declare an int to count the entries
            int count = 0;


            // userInput is split into two pieces, which are stored in this array of strings
            string[] parsedInput = new string[TEN];

            //Introduction for the user
            WriteLine("Hello, I wish to serve you and your friends in your bowling endeavors");
            WriteLine("\nPlease enter the name and score on 1 line separated by a SPACE");
            WriteLine("When you have entered the final team member\nsimply push enter and I will do the rest :)\n");

            // do while loop for as long as the answer is valid
            do
            {
                // the line of data input by the user is stored here
                userInput = ReadLine();

                if (userInput != "")
                {   // this line splits the string userInput into the two pieces
                    parsedInput = userInput.Split(' ');

                    // store the first piece, the name, in a string variable
                    bt.AddName(parsedInput[ZERO]);
       
                    int scores = int.Parse(parsedInput[ONE]);

                    // store the second piece, a score, in an integer variable
                    bt.AddScore(scores);

                    //Count the times it is used
                    count++;
                }
            } while (userInput != "");

            //get the arrays of names and scores and store them in local arrays
            name = bt.GetNames();
            score = bt.GetScores();

            //Display a break in the screen
            WriteLine("\n******Input Return*******\n");

            //Display the names and scores in order
            for (int i = ZERO; i < count; i++)
            {
                //Display an asterisk by the score if the score is 300
                if (score[i] == THREEHUNDRED)
                {
                    WriteLine($"{name[i]}\t{score[i]}*");
                }
                //Otherwise just display regularly
                else
                {
                    WriteLine($"{name[i]}\t{score[i]}");
                }
            }

            //Display the average score
            WriteLine($"\nThe Average Score: {bt.GetAvgScore()}");

            //Readkey to break the program
            ReadKey();
        }
    }
}
