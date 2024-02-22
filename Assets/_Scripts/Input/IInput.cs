using System;
using UnityEngine;

namespace _Scripts.Input
{
    public interface IInput
    {
        public event Action<Vector3> OnPointerDown;
        public event Action OnPointerUp;
        public event Action<Vector3> OnDrag;
    }
}