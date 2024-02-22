using System;
using _Scripts.Grid;
using _Scripts.Input;
using _Scripts.Towers;
using UnityEngine;
using Zenject;

namespace _Scripts
{
    public class SelectService : IDisposable
    {
        private IInput _input;
        private IGrid _grid;
        private ISelectable _selectable;

        public bool IsEmpty => _selectable == null;

        [Inject]
        public void Construct(IInput input, IGrid grid)
        {
            _input = input;
            _grid = grid;
            _input.OnPointerDown += TrySelect;
            _input.OnPointerUp += Deselect;
        }

        private void TrySelect(Vector3 touchPosition)
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(touchPosition, Camera.MonoOrStereoscopicEye.Mono);
            worldPoint.z = 0;
            _selectable = _grid.GetNearestCell(worldPoint);
            Select(_selectable);
        }

        private void Select(ISelectable selectable)
        {
            selectable.Select();
        }

        private void Deselect()
        {
            _selectable = null;
        }
        
        public void Dispose()
        {
            _input.OnPointerDown -= TrySelect;
            _input.OnPointerUp -= Deselect;
        }
    }
}