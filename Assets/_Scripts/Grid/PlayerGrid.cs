using System.Collections.Generic;
using System.Linq;
using _Scripts.Grid.Cells;
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

        public ICell GetEmptyCell()
        {
            return _cells.First(cell => cell.IsEmpty());
        }
    }
}