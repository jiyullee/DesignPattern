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
        int curPtr = 0;

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
          
            moveCommand = HandleInput(currentUnit);
            if (moveCommand != null)
            {
                CommandStack.Push(moveCommand);
                curPtr = 0;
                CommandStack.Peek().Execute();
            }
            
        }

        #endregion

        #region <Methods>

        public Command HandleInput(Unit currentUnit)
        {
            //if (Input.GetKeyDown(buttonX.GetKey)) return buttonX;
            //else if (Input.GetKeyDown(buttonY.GetKey)) return buttonY;

            //return null;
            
            if (currentUnit == null) return null;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                return new MoveUnitCommand(currentUnit, 0, 1);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                return new MoveUnitCommand(currentUnit, 0, -1);
            }

            return null;
        }

        public void OnClick_Undo()
        {
            Debug.Log(curPtr);
            if (curPtr  == CommandStack.Count)
            {
                return;
            }
            CommandStack.ToArray()[curPtr++].Undo();
        }

        public void OnClick_Redo()
        {
            if (curPtr <= 0)
            {
                curPtr = 0;
                return;
            }
            CommandStack.ToArray()[--curPtr].Execute();
        }
        #endregion

    }

}