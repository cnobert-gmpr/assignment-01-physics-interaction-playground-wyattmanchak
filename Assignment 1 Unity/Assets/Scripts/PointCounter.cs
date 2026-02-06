using UnityEngine;
using UnityEngine.UI;

namespace GMPR2512.Assignment1
{
    public class PointCounter : MonoBehaviour
    {
        [SerializeField] private Text _textMesh;
        private int _pointCount = 0;

        void Start()
        {
            _textMesh.text = $"Points : {_pointCount}";
        }

        public void AddPointToCount()
        {
            _pointCount++;
            _textMesh.text = $"Points : {_pointCount}";
        }

        public void ResetPoints()
        {
            _pointCount = 0;
            _textMesh.text = $"Points : {_pointCount}";
        }
    }
}
