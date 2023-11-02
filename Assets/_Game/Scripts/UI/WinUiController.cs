using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class WinUiController : UIController<WinUiController>
    {
        [SerializeField] private Button _nextButton;

        private void OnEnable()
        {
            _nextButton.onClick.AddListener(NextButtonPressed);
        }

        private void OnDisable()
        {
            _nextButton.onClick.RemoveListener(NextButtonPressed);
        }

        private void NextButtonPressed()
        {
            HideInstant();
        }
    }

}
