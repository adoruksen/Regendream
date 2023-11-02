using Sirenix.OdinInspector;
using UnityEngine;
using CharacterController = CharacterSystem.CharacterController;

namespace Managers
{
    public class CharacterManager : MonoBehaviour
    {
        public static CharacterManager Instance;
        [ShowInInspector] public CharacterController CurrentPlayer { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public void SetCurrentCharacter(CharacterController character)
        {
            CurrentPlayer = character;
        }
    }
}

