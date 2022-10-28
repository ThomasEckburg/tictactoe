using System;
using System.Collections;
using System.Collections.Generic;
using Tic;
using UnityEngine;

public class ClickableTile : MonoBehaviour
{
    public Action<int, int> onTileSelected;

    public void Init(int x, int y)
    {
        this.x = x;
        this.y = y;
        gameObject.transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
    }

    public int x, y;
    private void OnMouseDown()
    {
        Debug.Log($"Clicked tile: ${x}, ${y}");
        if(onTileSelected != null)
        {
            onTileSelected(x, y);
        }
    }

}
