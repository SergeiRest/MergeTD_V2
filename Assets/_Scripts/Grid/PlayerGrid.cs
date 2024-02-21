using System.Collections.Generic;
using _Scripts.Grid.Cells;
using UnityEngine;
using Zenject;

namespace _Scripts.Grid
{
    public class PlayerGrid : IGrid
    {
        private List<ICell> _cells = new List<ICell>();
        
        [Inject]
        public void Construct(GridTemplate gridTemplate)
        {
            foreach (var cell in gridTemplate.Cells)
            {
                _cells.Add(new Cell(cell.transform));
            }
        }
    }
}