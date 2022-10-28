using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tic
{
    public class Player : MonoBehaviour
    {
        public GameObject piecePrefab;
        public int score;
        public int goalScore = 10;
        private void Awake()
        {
            score = 0;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

