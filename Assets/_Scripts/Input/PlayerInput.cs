using System;
using UnityEngine;
using Zenject;

namespace _Scripts.Input
{
    public class PlayerInput : IInput, ITickable, IDisposable
    {
        public event Action OnPointerDown;
        public event Action OnPointerUp;
        public event Action OnDrag;
        
        public void Tick()
        {
            if(UnityEngine.Input.GetMouseButtonDown(0))
                OnPointerDown?.Invoke();
        }

        public void Dispose()
        {
        }
    }
}