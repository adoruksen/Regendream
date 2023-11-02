using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.State
{
    [Serializable]
    public abstract class State
    {
        public event Action<IHaveState> OnStateEntered;
        public event Action<IHaveState> OnStateExited;
        
        protected virtual void OnStateEnter(IHaveState controller) { }

        public virtual void OnStateFixedUpdate(IHaveState controller) { }
        public virtual void OnStateUpdate(IHaveState controller) { }


        protected virtual void OnStateExit(IHaveState controller) { }

        public void StateEnter(IHaveState controller)
        {
            OnStateEnter(controller);
            OnStateEntered?.Invoke(controller);
        }

        public void StateExit(IHaveState controller)
        {
            OnStateExit(controller);
            OnStateExited?.Invoke(controller);
        }
    }
}

