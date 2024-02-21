using System;
using _Scripts.Input;
using UnityEngine;
using Zenject;

namespace _Scripts.Grid
{
    public class PointerListener : IDisposable
    {
        private IGrid _grid;
        private IInput _input;
        
        [Inject]
        public void Construct(IInput input, IGrid grid)
        {
            _input = input;
            _grid = grid;

            _input.OnPointerDown += PointerDown;
        }

        public void Dispose()
        {
            _input.OnPointerDown -= PointerDown;
        }

        private void PointerDown()
        {
        }
    }
}