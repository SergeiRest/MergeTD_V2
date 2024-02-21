using System;
using _Scripts.Factories;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _Scripts.UI.TowerCreatorView
{
    public class TowerSpawnRequest : MonoBehaviour
    {
        [SerializeField] private Button _requestButton;
        [Inject] private ITowerFactory _towerFactory;

        private void Start()
        {
            _requestButton.onClick.AddListener(_towerFactory.GetRandom);
        }
    }
}