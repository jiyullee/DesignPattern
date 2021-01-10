using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yul
{
    public class InputHandler : MonoBehaviour
    {
        #region <Fields>

        private Command buttonX;
        private Command buttonY;
        private Command buttonA;
        private Command buttonB;

        Command moveCommand;
        Stack<Command> CommandStack = new Stack<Command>();
        int curPtr = -1;

        public GameActor actor_a;
        public GameActor actor_b;
        private GameActor currentActor;

        public Unit[] units;

        private Unit currentUnit;
        #endregion

        #region <Callbacks>

        private void Awake()
        {
            buttonX = new JumpCommand();
            buttonY = new FireCommand();
        }

        private void Update()
        {
            //if (Input.GetKeyDown(KeyCode.A)) currentActor = actor_a;
            //else if (Input.GetKeyDown(KeyCode.B)) currentActor = actor_b;

            //if (!currentActor) return;

            //Command command = HandleInput();
            //if (command != null)
            //{
            //    command.Execute(currentActor);
            //}

            if (Input.GetKeyDown(KeyCode.Alpha1)) currentUnit = units[0];
            else if (Input.GetKeyDown(KeyCode.Alpha2)) currentUnit = units[1];
            else if (Input.GetKeyDown(KeyCode.Alpha3)) currentUnit = units[2];

            moveCommand = HandleInput();
            if (moveCommand != null)
            {
                PushCommand(moveCommand);
                CommandStack.ToArray()[curPtr]     
            }
            Debug.Log(CommandStack.Count);
        }

        #endregion

        #region <Methods>

        public Command HandleInput()
        {
            //if (Input.GetKeyDown(buttonX.GetKey)) return buttonX;
            //else if (Input.GetKeyDown(buttonY.GetKey)) return buttonY;

            //return null;

            Unit unit = currentUnit;
            if (unit == null) return null;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                int destY = currentUnit.Y + 1;
                return new MoveUnitCommand(unit, unit.X, destY);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                int destY = currentUnit.Y - 1;
                return new MoveUnitCommand(unit, unit.X, destY);
            }

            return null;
        }

        public void Undo()
        {        
            if (--curPtr < 0)
                curPtr = 0;
            Debug.Log(CommandStack.ToArray()[curPtr]);
            CommandStack.ToArray()[curPtr].Undo();
        }

        public void PushNewCommand(Command command)
        {
            CommandStack.Push(command);
            curPtr = CommandStack.
        }

        #endregion

    }

}