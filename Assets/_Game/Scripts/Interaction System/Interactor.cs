using UnityEngine;
using System.Collections.Generic;
using Managers;

namespace InteractionSystem
{
    public class Interactor : MonoBehaviour
    {
        private IInteractor _controller;
        public bool canInteract;
    
        private void Awake()
        {
            _controller = GetComponentInParent<IInteractor>();
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (!canInteract || !GameManager.Instance.isPlaying) return;
            if (!other.CompareTag(tag)) return;
            
            var hasBeginInteractable = other.TryGetComponent<IBeginInteract>(out var interactable);
            if (hasBeginInteractable && interactable.IsInteractable) interactable.OnInteractBegin(_controller);
        }
        private void OnTriggerExit(Collider other)
        {
            if (!canInteract || !GameManager.Instance.isPlaying) return;
            if (!other.CompareTag(tag)) return;
            
            var hasEndInteractable = other.TryGetComponent<IEndInteract>(out var interactable);
            if (hasEndInteractable && interactable.IsInteractable) interactable.OnInteractEnd(_controller);
        }
    }

}
