using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridScript : MonoBehaviour
{
    public Tilemap map;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    private Vector3Int CurrentCell { get => map.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)); }
    private Vector3? draggingCameraPos;
    private void OnMouseDown()
    {
        draggingCameraPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //var currentCell = CurrentCell;
        //if (units.GetTile(currentCell) == null)
        //{
        //    draggingCameraPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    return;
        //}
        //else
        //{
        //    draggingCameraPos = null;
        //}
        //mouseDownCell = currentCell;

    }
    private void OnMouseUp()
    {
        draggingCameraPos = null;

        //Vector3Int currentCell = CurrentCell;
        //selectCell(currentCell);

        //map.SetTile(currentCell, C);
        //draggingCameraPos = null;
        //if (mouseDownCell == null)
        //{
        //    return;
        //}
        //foreach (var currentDragedoverTile in draggedTiles)
        //{
        //    units.SetTile(currentDragedoverTile, null);
        //}

        //draggedTiles.Clear();
        //if (currentCell == mouseDownCell)
        //{
        //    return;
        //}
        //if (map.GetTile(currentCell) == null)
        //{
        //    return;
        //}
        //if (units.GetTile(currentCell) != null)
        //{
        //    return;
        //}

        //var sourceTile = units.GetTile(mouseDownCell.Value);
        //units.SetTile(mouseDownCell.Value, null);
        //units.SetTile(currentCell, sourceTile);
        //mouseDownCell = null;

    }
    private void OnMouseDrag()
    {
        if (draggingCameraPos != null)
        {
            var worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var vector = draggingCameraPos.Value - worldPosition;
            Debug.Log($"draggingCameraPos={draggingCameraPos} worldPosition={worldPosition} vector={vector} Camera.main.transform.position={Camera.main.transform.position}");
            Camera.main.transform.position += vector;
            return;
        }
        //if (mouseDownCell == null)
        //{
        //    return;
        //}
        //var currentCell = CurrentCell;
        //if (currentCell == mouseDownCell)
        //{
        //    return;
        //}
        //var currentTile = units.GetTile(currentCell);
        //if (currentTile != null)
        //{
        //    return;
        //}
        //var mapTile = map.GetTile(currentCell);
        //if (mapTile == null)
        //{
        //    return;
        //}
        //draggedTiles.Add(currentCell);
        //units.SetTile(currentCell, smallCrown);
    }
}
