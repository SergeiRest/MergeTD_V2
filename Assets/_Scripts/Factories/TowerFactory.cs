using System.Linq;
using _Scripts.Data;
using _Scripts.Grid;
using _Scripts.Grid.Cells;
using _Scripts.Towers;
using UnityEngine;
using Zenject;

namespace _Scripts.Factories
{
    public class TowerFactory : ITowerFactory
    {
        [Inject] private TowersData _towersData;
        [Inject] private IGrid _grid;
        
        public void GetRandom()
        {
            var available = _towersData.Towers.Where(tower => tower.Level == 1).ToArray();
            int random = Random.Range(0, available.Length);

            Tower selected = available[random];
            ICell emptyCell;
            if (_grid.TryGetCell(out emptyCell))
            {
                TowerTemplate template = Object.Instantiate(selected.Prefab, emptyCell.Transform, true);
                ITower tower = new BasicTower(template.transform);
                emptyCell.SetChild(tower);
            }
        }
    }
}