using _Scripts.Towers;
using UnityEngine;

namespace _Scripts.Grid.Cells
{
    public interface ICell
    {
        public Transform Transform { get; }

        public bool IsEmpty();
        public void SetChild(ITower tower);
    }
}