using System.Collections;
using GameSystem.States;
using General.State;
using Managers;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GameSystem
{
    public class GameStateController : MonoBehaviour
    {
        private GameController _controller;
        
        public GameState GameState = new();
        public FailGameState FailGameState = new();
        public WinGameState WinGameState = new();
        [ShowInInspector] public State CurrentState { get; private set; }

        private void Awake()
        {
            _controller = GetComponent<GameController>();
        }

        private IEnumerator Start()
        {
            yield return new WaitUntil(() => GameManager.Instance.isPlaying);
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

