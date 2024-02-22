using System;
using UnityEngine;
using Zenject;

namespace _Scripts.Input
{
    public class PlayerInput : IInput, ITickable, IDisposable
    {
        private Vector3 previousPosition;
        
        public event Action<Vector3> OnPointerDown;
        public event Action OnPointerUp;
        public event Action<Vector3> OnDrag;

        [Inject] private SelectService _selectService;
        
        public void Tick()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                previousPosition = UnityEngine.Input.mousePosition;
                OnPointerDown?.Invoke(previousPosition);
                return;
            }

            if (!_selectService.IsEmpty &&
                Vector3.Distance(previousPosition, UnityEngine.Input.mousePosition) > 30)
            {
                previousPosition = UnityEngine.Input.mousePosition;
                OnDrag?.Invoke(previousPosition);
            }

            if (UnityEngine.Input.GetMouseButtonUp(0))
            {
                OnPointerUp?.Invoke();
            }
        }

        public void Dispose()
        {
        }
    }
}