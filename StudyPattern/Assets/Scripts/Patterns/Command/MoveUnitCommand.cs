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
            _xBefore = 0;
            _yBefore = 0;
            _x = x;
            _y = y;        
        }

        public override void Execute()
        {
            _xBefore = unit.X;
            _yBefore = unit.Y;
            unit.MoveTo(_x, _y);
        }

        public override void Execute(GameActor actor)
        {
            
        }

        public override void Undo()
        {
            Debug.Log("Undo : " + _xBefore + " " + _yBefore);
            unit.MoveTo(_xBefore, _yBefore);
        }
    }
}
