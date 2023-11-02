using UnityEngine;
using CharacterController = CharacterSystem.CharacterController;

namespace Managers
{
    public class CharacterManager : MonoBehaviour
    {
        public static CharacterManager Instance;
        public CharacterController CurrentPlayer { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public void SetCurrentCharacter(CharacterController character)
        {
            CurrentPlayer = character;
            Debug.Log(CurrentPlayer.gameObject.name);
        }
    }
}

