using System;
using General.State;
using UnityEngine;

namespace CharacterSystem
{
    public class CharacterController : MonoBehaviour,IHaveState
    {
        public CharacterAnimationController AnimationController { get; private set; }
        public CharacterMovementController MovementController { get; private set; }
        public CharacterStateController StateController { get; private set; }

        private void Awake()
        {
            AnimationController = GetComponent<CharacterAnimationController>();
            MovementController = GetComponent<CharacterMovementController>();
            StateController = GetComponent<CharacterStateController>();
        }
    }
}

