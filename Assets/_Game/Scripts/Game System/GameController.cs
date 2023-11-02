using General.State;
using UnityEngine;

namespace GameSystem
{
    public class GameController : MonoBehaviour,IHaveState
    {
        public GameStateController StateController { get; private set; }

        private void Awake()
        {
            StateController = GetComponent<GameStateController>();
        }
    }
}

