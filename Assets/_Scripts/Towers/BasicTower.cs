using UnityEngine;

namespace _Scripts.Towers
{
    public class BasicTower : ITower, IMoveable
    {
        public BasicTower(Transform transform)
        {
            Transform = transform;
        }
        
        public Transform Transform { get; }
        
        public void Move(Vector3 pos)
        {
            Transform.position = pos;
        }
    }
}