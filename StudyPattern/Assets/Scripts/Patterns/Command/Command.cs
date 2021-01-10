using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yul
{
    public abstract class Command
    {
        protected KeyCode CommandKey;
        public abstract void Execute();
        public abstract void Execute(GameActor actor);
        public abstract void Undo();

        public KeyCode GetKey => CommandKey;
        public void SetKey(KeyCode key) => CommandKey = key;
    }
}

