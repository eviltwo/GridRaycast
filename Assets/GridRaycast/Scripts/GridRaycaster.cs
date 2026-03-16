using UnityEngine;

namespace GridRaycast
{
    public static class GridRaycaster
    {
        public static int Raycast(
            Grid grid,
            Ray ray,
            GridRaycastHit[] results,
            float maxDistance)
        {
            var origin = grid.transform.InverseTransformPoint(ray.origin);
            var cell = grid.LocalToCell(origin);
            var dir = grid.transform.InverseTransformDirection(ray.direction);
            var cellSize = grid.cellSize + grid.cellGap;

            var step = new Vector3Int();
            var nextBoundary = new Vector3();
            var tMax = new Vector3();
            var tDelta = new Vector3();
            for (var dim = 0; dim < 3; dim++)
            {
                step[dim] = dir[dim] > 0 ? 1 : -1;
                nextBoundary[dim] = (cell[dim] + (step[dim] > 0 ? 1 : 0)) * cellSize[dim];
                tMax[dim] = dir[dim] != 0 ? (nextBoundary[dim] - origin[dim]) / dir[dim] : float.PositiveInfinity;
                tDelta[dim] = dir[dim] != 0 ? cellSize[dim] / Mathf.Abs(dir[dim]) : float.PositiveInfinity;
            }

            var hitCount = 0;
            var t = 0f;
            for (var i = 0; i < results.Length; i++)
            {
                var minDim = tMax.x < tMax.y ? tMax.x < tMax.z ? 0 : 2 : tMax.y < tMax.z ? 1 : 2;
                cell[minDim] += step[minDim];
                t = tMax[minDim];
                tMax[minDim] += tDelta[minDim];

                if (t > maxDistance) break;

                var normal = Vector3Int.zero;
                normal[minDim] = -step[minDim];
                results[i] = new GridRaycastHit
                {
                    cell = cell,
                    distance = t,
                    normal = normal,
                };
                hitCount = i + 1;
            }

            return hitCount;
        }
    }
}
