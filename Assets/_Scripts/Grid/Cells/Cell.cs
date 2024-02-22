using _Scripts.Towers;
using UnityEngine;
using Zenject;

namespace _Scripts.Grid.Cells
{
    public class Cell : ICell
    {
        [Inject] private TowerMovementService _towerMovementService;
        
        private ITower _child;
        
        public ITower Child => _child;
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

        public void Select()
        {
            if(IsEmpty())
                return;
            
            _towerMovementService.PrepareToMove(_child);
        }
    }
}