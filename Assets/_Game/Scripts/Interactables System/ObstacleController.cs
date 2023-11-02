using UnityEngine;
using System;
using InteractableSystem.Obstacle;
using InteractionSystem;
using Sirenix.OdinInspector;
using CharacterController = CharacterSystem.CharacterController;

namespace InteractableSystem
{
    public class ObstacleController : MonoBehaviour ,IBeginInteract
    {
        public event Action OnDumped;
        
        public ObstacleAnimationController Animation { get; private set; }
        
        [ShowInInspector, ReadOnly] public bool IsInteractable { get; private set; } = true;

        private void Awake()
        {
            Animation = GetComponentInChildren<ObstacleAnimationController>();
        }

        public void OnInteractBegin(IInteractor interactor)
        {
            var controller = (CharacterController)interactor;
            Dump(controller);
            controller.AnimationController.TriggerFall();
            Animation.CollisionDetectionHandle();
        }

        private void Dump(CharacterController controller)
        {
            Debug.Log("calisti");
            OnDumped?.Invoke();
            controller.StackController.LoseAllStack();
        }
    }
}
