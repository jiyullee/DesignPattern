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
  
        }
        public void MoveTo(int x, int y)
        {
            transform.Translate(new Vector2(x, y));
        }
    }
}
