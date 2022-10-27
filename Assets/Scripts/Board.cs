using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine;

namespace Tic
{
public class Board : MonoBehaviour
{
    public int boardWidth, boardHeight;
    public ClickableTile[] clickableTiles;
    public GameObject clickableTilePrefab;

    private void Awake()
    {
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                Debug.Log(x);
                Debug.Log(y);
                Assert.IsNotNull(clickableTilePrefab);
                ClickableTile newTile = Instantiate(clickableTilePrefab).GetComponent<ClickableTile>();
                newTile.Init(x, y);
            }
        }
    }
}
}
