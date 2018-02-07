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
        public void GamePlay()
        {
            //Display Intro Screen
            //Display Introduction/Directions/Instruction

            GetPlayers();

        }

        private void GetPlayers()
        {
            int NumberOfPlayer = GetNumberOfPlayers();
        }

        private int GetNumberOfPlayers()
        {
            int numberOfPlayers = interaction.GetIntInput("Please enter the number of players:");
            return numberOfPlayers;
        }
    }
}
