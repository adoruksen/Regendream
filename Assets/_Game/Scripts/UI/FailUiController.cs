using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class FailUiController : UIController<FailUiController>
    {
        [SerializeField] private Button _retryButton;

        private void OnEnable()
        {
            _retryButton.onClick.AddListener(RetryButtonPressed);
        }

        private void OnDisable()
        {
            _retryButton.onClick.RemoveListener(RetryButtonPressed);
        }

        private void RetryButtonPressed()
        {
            HideInstant();
        }
    }

}
