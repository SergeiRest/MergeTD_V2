using _Scripts.Towers;
using UnityEngine;

namespace _Scripts.Grid.Cells
{
    public class Cell : ICell
    {
        private ITower _child;
        public Transform Transform { get; }

        public Cell(Transform transform)
        {
            Transform = transform;
        }
        
        public bool IsEmpty()
        {
            return _child == null;
        }

        public void SetChild(ITower tower)
        {
            _child = tower;
            _child.Transform.SetParent(Transform);
            _child.Transform.localPosition = Vector3.zero;
            _child.Transform.localScale = Vector3.one;
        }
    }
}