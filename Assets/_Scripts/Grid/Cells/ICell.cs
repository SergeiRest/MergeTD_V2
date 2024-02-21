using UnityEngine;

namespace _Scripts.Grid.Cells
{
    public interface ICell : ISelectedUnit
    {
        public Transform Transform { get; }
    }
}