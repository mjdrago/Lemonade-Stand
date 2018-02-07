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
        public void GamePlay()
        {
            //Display Intro Screen
            //Display Introduction/Directions/Instruction

            GetPlayers();

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
            return numberOfPlayers;
        }
    }
}
