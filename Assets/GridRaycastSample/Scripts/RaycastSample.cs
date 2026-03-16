using GridRaycast;
using UnityEngine;

namespace GridRaycastSample
{
    public class RaycastSample : MonoBehaviour
    {
        public Grid Grid;

        public Transform RayObject;

        public float Distance = 1;

        private readonly GridRaycastHit[] _hitBuffer = new GridRaycastHit[100];

        private void OnDrawGizmos()
        {
            if (Grid == null) return;
            if (RayObject == null) return;

            var ray = new Ray(RayObject.position, RayObject.forward);
            var hitCount = GridRaycaster.Raycast(Grid, ray, _hitBuffer, Distance);
            Gizmos.color = Color.white;
            Gizmos.DrawRay(ray.origin, ray.direction * Distance);
            Gizmos.color = Color.red;
            for (var i = 0; i < hitCount; i++)
            {
                var hit = _hitBuffer[i];
                var point = ray.GetPoint(hit.distance);
                Gizmos.DrawCube(point, Vector3.one * 0.1f);
                Gizmos.DrawWireCube(Grid.GetCellCenterWorld(hit.cell), Grid.cellSize);
                Gizmos.DrawLine(point, point + Grid.transform.TransformDirection(hit.normal) * 0.2f);
            }
        }
    }
}
