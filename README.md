# Grid Raycast for Unity
A lightweight utility that returns all Unity Grid cells intersected by a Ray.

This package performs a fast grid traversal based on Unity's built-in Grid component and returns the cells the ray passes through up to a specified distance.

No colliders or physics queries are required, making it useful for grid-based games such as tile systems, voxel worlds, and strategy games.

Useage:
```
var hitCount = GridRaycaster.Raycast(grid, ray, hitBuffer, distance);
```

Currently supports only Grid CellLayout = Rectangle.

# Install with UPM
```
https://github.com/eviltwo/GridRaycast.git?path=Assets/GridRaycast
```
