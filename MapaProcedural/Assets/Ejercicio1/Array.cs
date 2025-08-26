using UnityEngine;

public class Array
{
    public int[] numeros = new int[4];
    public string[] nombre = new string[5];
    public int[,] multi = new int[4,2];
    


    void Start()
    {
        numeros[2] = 3;

        nombre[0] = "Caza";
        nombre[1] = "Caza";
        nombre[2] = "Caza";
        nombre[3] = "Caza";
        nombre[4] = "Caza";

        foreach (int number in numeros)
        {
            Debug.Log("Número: " + number);
        }
    }

    
}
