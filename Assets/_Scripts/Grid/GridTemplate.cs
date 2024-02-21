using _Scripts.Grid.Cells;
using UnityEngine;

namespace _Scripts.Grid
{
    public class GridTemplate : MonoBehaviour
    {
        [field: SerializeField] public CellTemplate[] Cells { get; private set; }
    }
}