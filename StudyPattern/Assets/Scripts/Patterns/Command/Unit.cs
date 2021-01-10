using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yul
{
    public class Unit : MonoBehaviour
    {
        public int X;
        public int Y;

        private void Awake()
        {
            X = 0;
            Y = 0;

            transform.position = new Vector3(X, Y, 0);

        }
        public void MoveTo(int x, int y)
        {
            transform.Translate(new Vector2(x, y));
        }
    }
}
