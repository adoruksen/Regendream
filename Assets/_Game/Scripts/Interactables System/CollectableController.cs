using UnityEngine;
using System;
using InteractionSystem;
using Managers;
using Sirenix.OdinInspector;
using Random = UnityEngine.Random;
using CharacterController = CharacterSystem.CharacterController;

namespace InteractableSystem
{
    public class CollectableController : MonoBehaviour ,IBeginInteract
    {
        public event Action OnCollected;

        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Collider _collider;
        [SerializeField] private float _verticalForce;
        [SerializeField] private float _horizontalForce;

        [ShowInInspector, ReadOnly] public bool IsInteractable { get; private set; } = true;

    
        public void OnInteractBegin(IInteractor interactor)
        {
            var controller = (CharacterController)interactor;
        
            Collect(controller);
        }

        private void Collect(CharacterController controller)
        {
            OnCollected?.Invoke();
            controller.StackController.AddStack(this);
            SetInteractable(false);
        }

        public void SetLost()
        {
            transform.SetParent(null);
            SetInteractable(true);
            FlingBrick();
        }

        private void SetInteractable(bool interactable)
        {
            _collider.enabled = interactable;
            _rigidbody.isKinematic = !interactable;
            IsInteractable = interactable;
        }

        private void FlingBrick()
        {
            Vector3 force = Random.insideUnitCircle * _horizontalForce;
            force = new Vector3(force.x, Random.value * _verticalForce, force.y);
            _rigidbody.AddForce(force);
        }
    }

}
