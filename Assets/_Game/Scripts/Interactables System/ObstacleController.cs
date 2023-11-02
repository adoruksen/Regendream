using UnityEngine;
using System;
using InteractionSystem;
using Sirenix.OdinInspector;
using CharacterController = CharacterSystem.CharacterController;

namespace InteractableSystem
{
    public class ObstacleController : MonoBehaviour ,IBeginInteract
    {
        public event Action OnDumped;
        
        [ShowInInspector, ReadOnly] public bool IsInteractable { get; private set; } = true;
        
        public void OnInteractBegin(IInteractor interactor)
        {
            var controller = (CharacterController)interactor;
            Dump(controller);
            controller.AnimationController.TriggerFall();
        }

        private void Dump(CharacterController controller)
        {
            Debug.Log("calisti");
            OnDumped?.Invoke();
            controller.StackController.LoseAllStack();
        }
    }
}
