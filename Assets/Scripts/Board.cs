using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine;

namespace Tic
{
    public class Board : MonoBehaviour
    {
        public int boardWidth, boardHeight;
        public ClickableTile[,] clickableTiles;
        public Piece[,] pieces;
        public GameObject clickableTilePrefab;

        private void Awake()
        {
            Assert.IsNotNull(clickableTilePrefab);
            clickableTiles = new ClickableTile[boardWidth, boardHeight];
            pieces = new Piece[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    ClickableTile newTile = Instantiate(clickableTilePrefab).GetComponent<ClickableTile>();
                    newTile.Init(x, y);
                    clickableTiles[x, y] = newTile;
                }
            }
        }
    }
}
