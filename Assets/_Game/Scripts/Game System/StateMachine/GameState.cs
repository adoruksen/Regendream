using General.State;
using Managers;

namespace GameSystem.States
{
    public class GameState : State
    {
        protected override void OnStateEnter(IHaveState controller)
        {
            var player = CharacterManager.Instance.CurrentPlayer;
            player.StateController.SetState(player.StateController.MoveState);
        }
    }
}

