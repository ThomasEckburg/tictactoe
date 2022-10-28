using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine;

namespace Tic
{
    public class GameTask : TicTask
    {
        public Board board;
        public Player[] players;
        private Player _activePlayer;
        // Start is called before the first frame update
        void Start()
        {

        }

        public void StartGame()
        {
            foreach(var tile in board.clickableTiles)
            {
                tile.onTileSelected = OnTileSelected;
            }
        }

        public async Task StartGameTask()
        {
            Assert.IsNotNull(players);
        }


        private async Task GameLoop()
        {
            await StartGameTask();

            while (!GameIsOver())
            {
                for(int playerIndex = 0; ; playerIndex++)
                {
                    _activePlayer = players[playerIndex % players.Length];
                }
            }
        }

        private bool GameIsOver()
        {
            foreach(Player player in players)
            {
                if(player.score >= player.goalScore)
                {
                    return true;
                }
            }
            return false;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTileSelected(int x, int y)
        {
            if(board.pieces[x, y] != null)
            {
                return;
            }
            Debug.Log("Tile selected");
        }
    }
}
