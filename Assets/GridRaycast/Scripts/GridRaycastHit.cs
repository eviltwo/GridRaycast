using UnityEngine;

namespace GridRaycast
{
    public struct GridRaycastHit
    {
        public Vector3Int cell;
        public Vector3Int normal;
        public float distance;
    }
}
