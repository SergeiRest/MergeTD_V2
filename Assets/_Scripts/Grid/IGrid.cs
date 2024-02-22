using _Scripts.Grid.Cells;
using UnityEngine;

namespace _Scripts.Grid
{
    public interface IGrid
    {
        public bool TryGetCell(out ICell cell);
        public ICell GetNearestCell(Vector3 position);
    }
}