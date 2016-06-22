using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    class BowlingTeam
    {
        //Declare some fields for the class
        private string[] bowlingName = new string[TEN];
        private int[] bowlingScore = new int[TEN];
        private int
            numNames,
            numScore,
            totalScore,
            avgScore;

        //Declare some ints globally
        int i = 0;
        int j = 0;

        //Declare const int
        const int
            ZERO = 0,
            ONE = 1,
            TEN = 10;

        /// <summary>
        /// Add Name Handler
        /// </summary>
        /// <param name="name"></param>
        public void AddName(string name)
        {
            
            //add the name to the stored array of names
            bowlingName[i] = name;
            i++;
            numNames++;
        }

        /// <summary>
        /// Add Score Handler
        /// </summary>
        /// <param name="score"></param>
        public void AddScore(int score)
        {
            //Store the score in the array of scores
            bowlingScore[j] = score;
            j++;
            numScore++;
        }

        /// <summary>
        /// Get Names handler
        /// </summary>
        /// <returns></returns>
        public string[] GetNames()
        {
            return bowlingName;
        }

        public int[] GetScores()
        {
            //Write outer loop to test ints in the array
            for(int j = ZERO; j < numScore; j++)
            {
                //Write an inner loop to test ints in array
                for(int i = ZERO; i < numScore; i++)
                {
                    //Switch out the scores according to the larger as long as there is no zero 
                    if(bowlingScore[i + ONE] != 0 && bowlingScore[i] < bowlingScore[i + ONE])
                    {
                        //Use both swap and swapper methods to switch the bowling score and name
                        Swap(ref bowlingScore[i], ref bowlingScore[i + ONE]);
                        Swapper(ref bowlingName[i], ref bowlingName[i + ONE]);
                    }
                }
            }
            return bowlingScore;
        }

        /// <summary>
        /// Get the average score
        /// </summary>
        /// <returns></returns>
        public int GetAvgScore()
        {
            //Add the bowling scores up to get a total score
            for (int k = ZERO; k < numNames; k++)
            {
                totalScore += bowlingScore[k];
            }

            //Divide the total score by the number of entries added to find the average
            avgScore = totalScore / numNames;

            return avgScore;
        }

        /// <summary>
        /// Swap scores method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Swap names method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swapper(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}
