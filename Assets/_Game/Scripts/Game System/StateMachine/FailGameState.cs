using System.Collections;
using System.Collections.Generic;
using General.State;
using Managers;
using UnityEngine;

namespace GameSystem.States
{
    public class FailGameState : State
    {
        protected override void OnStateEnter(IHaveState controller)
        {
            var gameController = (GameController)controller;
            GameManager.Instance.FailGameHandler();
            
            var currentPlayer = CharacterManager.Instance.CurrentPlayer;
            currentPlayer.StateController.SetState(currentPlayer.StateController.FailState);
        }
    }
}

