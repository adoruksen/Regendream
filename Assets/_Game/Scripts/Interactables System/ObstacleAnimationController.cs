using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace InteractableSystem.Obstacle
{
    public class ObstacleAnimationController : MonoBehaviour
    {
        private Tween _rotateTween;
        private float _rotationDuration = 2f;

        private void Start()
        {
            RotateAroundTweenHandle();
        }

        private void RotateAroundTweenHandle()
        {
            _rotateTween = transform.DORotate(Vector3.forward * 360, _rotationDuration, RotateMode.LocalAxisAdd)
                .SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        }

        public void CollisionDetectionHandle()
        {
            _rotateTween.Pause();
            
            Invoke(nameof(ResumeRotation),2f);
        }

        private void ResumeRotation()
        {
            _rotateTween.Play();
        }
    }
}

