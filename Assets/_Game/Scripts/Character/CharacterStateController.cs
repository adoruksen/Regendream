using System;
using System.Collections;
using System.Collections.Generic;
using CharacterSystem.States;
using General.State;
using UnityEngine;

namespace CharacterSystem
{
    public class CharacterStateController : MonoBehaviour
    {
        private CharacterController _controller;
        
        public IdleState IdleState = new();
        public MoveState MoveState = new();
        public FailState FailState = new();
        public WinState WinState = new();
        public State CurrentState { get; private set; }

        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
        }

        private void Start()
        {
            SetState(IdleState);
        }

        private void FixedUpdate()
        {
            CurrentState?.OnStateFixedUpdate(_controller);
        }
        
        private void Update()
        {
            CurrentState?.OnStateUpdate(_controller);
        }
        
        private void ExitState()
        {
            CurrentState?.StateExit(_controller);
        }

        public void SetState(State newState)
        {
            ExitState();
            CurrentState = newState;
            CurrentState.StateEnter(_controller);
        }
    }
}

