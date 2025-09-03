using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class Map
{
    public TilemapController controller;
    public Map()
    {
        
    }
    public List<Vector3Int> GetOriginRectangle(int higth, int weigth)
    {
        List<Vector3Int> cordenadas = new List<Vector3Int>();
        for (int x = 0; x < weigth; x++)
        {
            for(int y = 0; y < higth; y++)
            {
                Vector3Int cordenada = new Vector3Int(x, y, 0);
                cordenadas.Add(cordenada);
            }
        }
        return cordenadas;     
    }
    public void Paint(List<Vector3Int>cordenadas,Tile tile,Tilemap tilemap)
    {
        foreach (var coordenada in cordenadas)
        {
            tilemap.SetTile(coordenada, tile);
        }
    }


    //Ejercicios
    public List<Vector3Int> GetOriginRectangle1(int higth, int weigth)
    {
        List<Vector3Int> cordenadas = new List<Vector3Int>();
        for (int x = 0; x < weigth; x++)
        {
            for (int y = 0; y <= x; y++)
            {
                Vector3Int cordenada = new Vector3Int(x, y, 0);
                cordenadas.Add(cordenada);
            }
        }
        return cordenadas;
    }
    public List<Vector3Int> GetOriginTriangle(int higth, int weigth)
    {
        List<Vector3Int> triangle = new List<Vector3Int>();
        for (int rw = 0; rw < weigth; rw++)
        {
            for (int rh = 0; rh < higth; rh++)
            {
                Vector3Int cor = new Vector3Int(rw, rh, 0);
                triangle.Add(cor);
            }
            higth--;
        }
        return triangle;
    }

    public List<Vector3Int> GetOriginHex(int length)
    {
        List<Vector3Int> triangle = new List<Vector3Int>();
        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < length; y++)
            {
                Vector3Int cor = new Vector3Int(x, y, 0);
                triangle.Add(cor);
            }
        }
        return triangle;
    }
}
