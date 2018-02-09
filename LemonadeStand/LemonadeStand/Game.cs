using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        UI interaction = new UI();
        List<Player> players = new List<Player>();
        Random generator = new Random();
        int gameLength;
        public Day currentDay;

        public void GamePlay()
        {
            //Display Intro Screen
            //Display Introduction/Directions/Instruction

            GetPlayers();
            GetTotalDays();
            RunThroughDays();
            DisplayFinalResults();
            RecordToHighScore();
            PlayAgain();
        }

        public void GetPlayers()
        {
            int numberOfPlayers = GetNumberOfPlayers();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Human inputPlayer = new Human();
                players.Add(inputPlayer);
            }
        }

        private int GetNumberOfPlayers()
        {
            int numberOfPlayers = interaction.GetIntInput("Please enter the number of players:");
            if (numberOfPlayers > 1)
            {
                return numberOfPlayers;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a number greater than 0.");
                return GetNumberOfPlayers();
            }
        }

        public void GetTotalDays()
        {
            int input = interaction.GetIntInput("Please enter for how many days you would like to play (at least 7 days).");
            if (input >= 7)
            {
                gameLength = input;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a number greater than or equal to 7.");
                GetTotalDays();
            }
        }

        private void RunThroughDays()
        {
            for (int i = 0; i < gameLength; i++)
            {
                currentDay = new Day(generator);
                foreach (Player activePlayer in players)
                {
                    currentDay.DaysAction(activePlayer);
                }
            }
        }

        private void RecordToHighScore()
        {
            throw new NotImplementedException();
        }

        private void DisplayFinalResults()
        {
            throw new NotImplementedException();
        }

        private void PlayAgain()
        {
            throw new NotImplementedException();
        }
    }
}
