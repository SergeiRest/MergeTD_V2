using System;
using _Scripts.Input;
using _Scripts.Towers;
using UnityEngine;
using Zenject;

namespace _Scripts
{
    public class TowerMovementService : IDisposable
    {
        [Inject] private IInput _input;
        
        private ITower _tower;
        private Camera _camera;

        public TowerMovementService()
        {
            _camera = Camera.main;
        }

        public void PrepareToMove(ITower tower)
        {
            _tower = tower;
            _input.OnDrag += Move;
            _input.OnPointerUp += Return;
        }

        private void Move(Vector3 mousePosition)
        {
            Vector3 worldPoint = _camera.ScreenToWorldPoint(mousePosition);
            worldPoint.z = 0;
            _tower.Move(worldPoint);
        }

        private void Return()
        {
            _tower.Transform.localPosition = Vector3.zero;
            _tower = null;
            UnSubscribe();
        }

        private void UnSubscribe()
        {
            _input.OnDrag -= Move;
            _input.OnPointerUp -= Return;
        }

        public void Dispose()
        {
            UnSubscribe();
        }
    }
}