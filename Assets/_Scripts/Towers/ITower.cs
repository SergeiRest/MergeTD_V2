using UnityEngine;

namespace _Scripts.Towers
{
    public interface ITower : IMoveable
    {
        public Transform Transform { get; }
    }
}