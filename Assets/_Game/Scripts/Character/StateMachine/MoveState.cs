using General.State;
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
            
        }
    }
}

