using System.Collections.Generic;
using System.Linq;
using _Scripts.Grid.Cells;
using UnityEngine;
using Zenject;

namespace _Scripts.Grid
{
    public class PlayerGrid : IGrid
    {
        private List<ICell> _cells = new List<ICell>();
        
        [Inject]
        public void Construct(GridTemplate gridTemplate, DiContainer container)
        {
            foreach (var cell in gridTemplate.Cells)
            {
                ICell newCell = new Cell(cell.transform);
                _cells.Add(newCell);
                container.Inject(newCell);
            }
        }

        public ICell GetEmptyCell()
        {
            if (_cells.Where(cell => cell.IsEmpty()).Count() > 0)
                return _cells.First(cell => cell.IsEmpty());
            else
                return null;
        }

        public bool TryGetCell(out ICell cell)
        {
            if (_cells.Count(c => c.IsEmpty()) > 0)
            {
                cell = _cells.First(available => available.IsEmpty());
                return true;
            }

            cell = null;
            return false;
        }

        public ICell GetNearestCell(Vector3 position)
        {
            ICell nearest = _cells[0];
            foreach (var cell in _cells)
            {
                if(Vector3.Distance(position, nearest.Transform.position)
                   > Vector3.Distance(position, cell.Transform.position))
                {
                    nearest = cell;
                }
            }
            
            return nearest;
        }
    }
}