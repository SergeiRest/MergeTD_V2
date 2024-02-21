using System;
using _Scripts.Towers;
using UnityEngine;

namespace _Scripts.Data
{
    [CreateAssetMenu(fileName = "TowersData", menuName = "Data/Towers")]
    public class TowersData : ScriptableObject
    {
        public Tower[] Towers;
    }


    [Serializable]
    public struct Tower
    {
        public TowerTemplate Prefab;
        public int Level;
        public Characteristic Characteristic;
    }

    [Serializable]
    public struct Characteristic
    {
        public int Damage;
        public float AttackInterval;
    }
}