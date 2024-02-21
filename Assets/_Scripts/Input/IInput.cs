using System;

namespace _Scripts.Input
{
    public interface IInput
    {
        public event Action OnPointerDown;
        public event Action OnPointerUp;
        public event Action OnDrag;
    }
}