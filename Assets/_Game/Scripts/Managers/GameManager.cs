using System;
using GameSystem;
using UISystem;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public static event Action OnGameInitialized;
        public static event Action OnGameStart;
        public static event Action OnGameEnd;

        public bool isPlaying = false;


        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            OnGameInitialized?.Invoke();
        }

        public void StartGame()
        {
            isPlaying = true;
            IntroUiController.Instance.HideInstant();
            OnGameStart?.Invoke();
        }

        public void FailGameHandler()
        {
            Debug.Log("Game Over!");
            FailUiController.Instance.Show();
            OnGameEnd?.Invoke();
        }

        public void WinGameHandler()
        {
            Debug.Log("You Win!");
            WinUiController.Instance.Show();
            OnGameEnd?.Invoke();
        }
    }
}
