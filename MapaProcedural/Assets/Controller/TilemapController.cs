using UnityEngine;
using UnityEngine.Tilemaps;


public class TilemapController : MonoBehaviour
{
    // 
    public Tile tile;
    void Start()
    {
        //1. crear un objeto vacio
        GameObject grid = new GameObject();
        grid.name = "Grid";

        //2. Asignarle un componente Grid (un objeto Grid)
        grid.AddComponent<Grid>();


        //2.1. agregar un CellLayout y un CellSize especifico
        Grid isogrid= grid.GetComponent<Grid>();
        isogrid.cellLayout=GridLayout.CellLayout.Isometric;
        isogrid.cellSize = new Vector3(1, 0.5f, 1);

        //3.Crear un nuevo objeto tipo TileMap
        GameObject tilemap = new GameObject();
        tilemap.name = "TileMap";       


        //4.Asignarle un componente TileMap y TilemapRenderer
        tilemap.AddComponent<Tilemap>();
        tilemap.AddComponent<TilemapRenderer>();

        //5.Asignarle a tilemap el padre grid
        tilemap.transform.parent = grid.transform;

        Tilemap map=tilemap.GetComponent<Tilemap>();
        map.SetTile(new Vector3Int(0,0,0),tile);

        Rectangle();
    }

    public void Rectangle()
    {
       

    }
}
