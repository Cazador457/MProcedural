using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class Map
{

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

    
    
}
