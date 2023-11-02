using General.State;
using Managers;
using UnityEngine;

namespace CharacterSystem.States
{
    public class IdleState : State
    {
        protected override void OnStateEnter(IHaveState controller)
        {
            var character = (CharacterController)controller;
            CharacterManager.Instance.SetCurrentCharacter(character);
        }

        protected override void OnStateExit(IHaveState controller)
        {
            var character = (CharacterController)controller;
        }
    }
}

