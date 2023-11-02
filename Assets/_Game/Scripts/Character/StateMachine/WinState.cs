using General.State;
using UnityEngine;

namespace CharacterSystem.States
{
    public class WinState : State
    {
        protected override void OnStateEnter(IHaveState controller)
        {
            var character = (CharacterController)controller;
        }
    }
}

