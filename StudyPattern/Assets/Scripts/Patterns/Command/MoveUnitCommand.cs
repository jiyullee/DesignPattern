using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yul
{
    public class MoveUnitCommand : Command
    {
        private Unit unit;
        int _x;
        int _y;
        int _xBefore;
        int _yBefore;

        public MoveUnitCommand(Unit unit, int x, int y)
        {
            this.unit = unit;
            _xBefore = -x;
            _yBefore = -y;
            _x = x;
            _y = y;        
        }

        public override void Execute()
        {
            unit.MoveTo(_x, _y);
        }

        public override void Execute(GameActor actor)
        {
            
        }

        public override void Undo()
        {
            unit.MoveTo(_xBefore, _yBefore);
        }
        
    }
}
