using General.State;
using Managers;

namespace GameSystem.States
{
    public class WinGameState : State
    {
        protected override void OnStateEnter(IHaveState controller)
        {
            GameManager.Instance.WinGameHandler();
            
            var currentPlayer = CharacterManager.Instance.CurrentPlayer;
            currentPlayer.StateController.SetState(currentPlayer.StateController.WinState);
        }
    }
}

