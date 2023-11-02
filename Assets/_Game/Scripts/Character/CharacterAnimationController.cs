using UnityEngine;

namespace CharacterSystem
{
    public class CharacterAnimationController : MonoBehaviour
    {
        private Animator _animator;
        private Rigidbody _rigidbody;
    
        [SerializeField] private GameObject[] _model;
        
        private static readonly int Speed = Animator.StringToHash("Speed");
        private static readonly int Fall = Animator.StringToHash("Fall");
        private static readonly int Win = Animator.StringToHash("Win");
        private static readonly int Fail = Animator.StringToHash("Fail");

        private void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
            _rigidbody = GetComponent<Rigidbody>();
        }
    
        void Update()
        {
            _animator.SetFloat(Speed, _rigidbody.velocity.magnitude);
            
        }
    
        public void SetModelActive(bool isActive)
        {
            foreach (var model in _model)
            {
                model.SetActive(isActive);
            }
        }
    
        public void TriggerFall() => _animator.SetTrigger(Fall);
        public void SetWin() => _animator.SetTrigger(Win);
        public void SetFail() => _animator.SetTrigger(Fail);
        
    }

}
