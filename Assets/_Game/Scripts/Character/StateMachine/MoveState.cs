using General.State;
using InputSystem;
using UnityEngine;

namespace CharacterSystem.States
{
    public class MoveState : State
    {
        private CharacterController _controller;
        protected override void OnStateEnter(IHaveState controller)
        {
            _controller = (CharacterController)controller;
        }

        public override void OnStateFixedUpdate(IHaveState controller)
        {
            var offset = InputManager.Module.NormalizedOffset;
            var direction = new Vector3(offset.x, 0f, offset.y);
            _controller.MovementController.Move(direction);
            if (offset.sqrMagnitude > .001f) _controller.MovementController.Look(direction);
        }
    }
}

