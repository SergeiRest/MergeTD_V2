using UnityEngine;

namespace _Scripts.Grid.Cells
{
    public class Cell : ICell
    {
        public Transform Transform { get; }

        public Cell(Transform transform)
        {
            Transform = transform;
        }

        public void Select()
        {
            Debug.Log("Select default");
        }
    }
}