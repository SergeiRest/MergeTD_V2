using System.Linq;
using _Scripts.Data;
using _Scripts.Towers;
using UnityEngine;
using Zenject;

namespace _Scripts.Factories
{
    public class TowerFactory : ITowerFactory
    {
        [Inject] private TowersData _towersData;
        
        public void GetRandom()
        {
            var available = _towersData.Towers.Where(tower => tower.Level == 1).ToArray();
            int random = Random.Range(0, available.Length);
            Debug.Log(available[random].Prefab.name);
        }
    }
}