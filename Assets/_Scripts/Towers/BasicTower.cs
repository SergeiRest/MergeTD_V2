using UnityEngine;

namespace _Scripts.Towers
{
    public class BasicTower : ITower
    {
        public BasicTower(Transform transform)
        {
            Transform = transform;
        }
        
        public Transform Transform { get; }
    }
}