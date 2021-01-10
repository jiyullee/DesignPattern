using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yul
{
    public class FireCommand : Command
    {
        public FireCommand()
        {
            CommandKey = KeyCode.Y;
        }

        public override void Execute(GameActor actor)
        {
            actor.Attack();
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }

        public override void Undo()
        {
            throw new System.NotImplementedException();
        }
    }

}