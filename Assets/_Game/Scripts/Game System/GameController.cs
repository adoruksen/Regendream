using General.State;
using UnityEngine;

namespace GameSystem
{
    public class GameController : MonoBehaviour,IHaveState
    {
        public static GameController Instance;
        public GameStateController StateController { get; private set; }

        private void Awake()
        {
            Instance = this;
            StateController = GetComponent<GameStateController>();
        }
    }
}

