using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tic
{
public class TicTask : MonoBehaviour
{
    public enum TaskState
    {
        Uninitialized,
        Pending,
        Executing,
        Finished,
        Cancelled
    }

    // Update is called once per frame
    void Update()
    {

    }
}
}

