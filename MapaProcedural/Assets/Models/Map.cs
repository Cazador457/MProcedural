using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class Map
{
    public enum MapType {Rectangle,Triangle,Line,Circle};
    private Vector2Int _origin;
    private Vector2Int _size;
    private Tilemap _tilemap;
    private MapType _type;

     

    public Map(Vector2Int origin,Vector2Int size,Tilemap tilemap, MapType type)
    {
        _origin = origin;
        _size = size;
        _tilemap = tilemap;
        _type = type;
    }

    public List<Vector3Int> GenerateCoordinates()
    {
        List<Vector3Int> cordenadas = new List<Vector3Int>();
        switch (_type)
        {
            case MapType.Rectangle:
                {
                    
                    for (int x = _origin.x; x < _size.x+_origin.x; x++)
                    {
                        for (int y = _origin.y; y < _size.y+_origin.y; y++)
                        {
                            Vector3Int cordenada = new Vector3Int(x, y, 0);
                            cordenadas.Add(cordenada);
                        }
                    }
                    return cordenadas;
                }
            case MapType.Triangle:
                {
                    for (int x = _origin.x; x < _size.x + _origin.x; x++)
                    {
                        for (int y = _origin.y; y < _size.y + _origin.y; y++)
                        {
                            Vector3Int cordenada = new Vector3Int(x, y, 0);
                            cordenadas.Add(cordenada);
                        }
                        _size.y--;
                    }
                    return cordenadas;
                }
                
            case MapType.Line:
                {
                    for (int x = _origin.x; x <= _size.y; x++)
                    {
                        Vector3Int cordenada = new Vector3Int(x, x, 0);
                        cordenadas.Add(cordenada);
                        
                    }
                    return cordenadas;
                }
                
            case MapType.Circle:
                {
                    for (int x = _origin.x; x < _size.x + _origin.x; x++)
                    {
                        for (int y = _origin.y; y < _size.y + _origin.y; y++)
                        {
                            Vector3Int cordenada = new Vector3Int(x, y, 0);
                            cordenadas.Add(cordenada);
                        }
                        
                    }
                    cordenadas.Remove(new Vector3Int(17, 3, 0));
                    cordenadas.Remove(new Vector3Int(17, 4, 0));
                    cordenadas.Remove(new Vector3Int(18, 3, 0));

                    cordenadas.Remove(new Vector3Int(17, 10, 0));
                    cordenadas.Remove(new Vector3Int(17, 9, 0));
                    cordenadas.Remove(new Vector3Int(18, 10, 0));

                    cordenadas.Remove(new Vector3Int(24, 3, 0));
                    cordenadas.Remove(new Vector3Int(23, 3, 0));
                    cordenadas.Remove(new Vector3Int(24, 4, 0));

                    cordenadas.Remove(new Vector3Int(24, 10, 0));
                    cordenadas.Remove(new Vector3Int(23, 10, 0));
                    cordenadas.Remove(new Vector3Int(24, 9, 0));
                    return cordenadas;
                    
                }
                
        }
        return cordenadas;
    }

    public void Render(List<Vector3Int> cordenadas, Tile tile)
    {
        foreach (var coordenada in cordenadas)
        {
            _tilemap.SetTile(coordenada, tile);
        }
    }
    /*
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
    */
}
