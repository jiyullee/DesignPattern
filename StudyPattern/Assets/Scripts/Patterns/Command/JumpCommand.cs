using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yul
{
    public class JumpCommand : Command
    {
        public JumpCommand()
        {
            CommandKey = KeyCode.X;
        }

        public override void Execute(GameActor actor)
        {
            actor.Jump();
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