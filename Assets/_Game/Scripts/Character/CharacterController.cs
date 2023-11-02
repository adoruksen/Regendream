using System;
using General.State;
using InteractionSystem;
using StackSystem;
using UnityEngine;

namespace CharacterSystem
{
    public class CharacterController : MonoBehaviour,IHaveState,IInteractor
    {
        public CharacterAnimationController AnimationController { get; private set; }
        public CharacterMovementController MovementController { get; private set; }
        public CharacterStateController StateController { get; private set; }
        public StackController StackController { get; private set; }

        private void Awake()
        {
            AnimationController = GetComponent<CharacterAnimationController>();
            MovementController = GetComponent<CharacterMovementController>();
            StateController = GetComponent<CharacterStateController>();
            StackController = GetComponent<StackController>();
        }
    }
}

