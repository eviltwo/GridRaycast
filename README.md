# Grid Raycast for Unity
A lightweight utility that returns all Unity Grid cells intersected by a Ray.

<img width="323" height="196" alt="Grid Raycast" src="https://github.com/user-attachments/assets/c1c4f5be-14d6-4e20-8629-50172cda47bc" />
<img width="269" height="174" alt="Grid Raycast 3D" src="https://github.com/user-attachments/assets/8c489883-bdf8-4054-b92f-145c4c9382be" />

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

# Support My Work
As a solo developer, your financial support would be greatly appreciated and helps me continue working on this project.
- [Asset Store](https://assetstore.unity.com/publishers/12117)
- [Steam](https://store.steampowered.com/curator/45066588)
- [GitHub Sponsors](https://github.com/sponsors/eviltwo)
