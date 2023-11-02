using UnityEngine;

namespace CharacterSystem
{
    public class CharacterMovementController : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        [SerializeField] private float _moveSpeed;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        
        public void Move(Vector3 direction)
        {
            var movement = direction * _moveSpeed;
            _rigidbody.velocity = movement;
        }

        public void MoveTo(Vector3 target)
        {
            var offset = target - _rigidbody.position;
            var direction = offset.sqrMagnitude > 1 ? offset.normalized : offset;
            direction.y = 0f;

            Move(direction);
            Look(direction);
        }

        public void Look(Vector3 direction)
        {
            var rotation = Quaternion.Lerp(_rigidbody.rotation, Quaternion.LookRotation(direction), .2f);
            _rigidbody.MoveRotation(rotation);
        }
    }
}

