using System.Collections;
using System.Collections.Generic;
using GameSystem.States;
using General.State;
using UnityEngine;

namespace GameSystem
{
    public class GameStateController : MonoBehaviour
    {
        private GameController _controller;
        
        public GameState GameState = new();
        public FailGameState FailGameState = new();
        public WinGameState WinGameState = new();
        public State CurrentState { get; private set; }

        private void Awake()
        {
            _controller = GetComponent<GameController>();
        }

        private void Start()
        {
            SetState(GameState);
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

