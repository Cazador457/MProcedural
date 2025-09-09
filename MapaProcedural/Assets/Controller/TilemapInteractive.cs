using UnityEngine;

public class TilemapInteractive : MonoBehaviour
{
    private Camera _mainCamera;
    private TilemapController tilemap;

    void Start()
    {
        if (_mainCamera == null)
        {
            _mainCamera = Camera.main;
        }
    }


    void Update()
    {
        if (_mainCamera != null)
        {
            Vector3 mousePosWorld = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(mousePosWorld);
        }

    }
    public void WorldtoCell()
    {
        Input.GetKeyDown("Space");
    }
    public void Highlight()
    {

    }
    public void ChangeTile()
    {

    }
}
