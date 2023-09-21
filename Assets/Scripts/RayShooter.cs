using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private string enemyTag = "Enemy";
    [SerializeField] private int damage = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkMouseInput();
    }
    
    private void OnGUI()
    {
        int size = 100;
        float posX = camera.pixelWidth / 2 - size / 4;
        float posY = camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "=|=");
    }
    
    void checkMouseInput()
    {
        if(!Input.GetMouseButtonDown(0)) return;
        
        var screenCenter = new Vector2(Screen.width/2, Screen.height/2);
        
        Ray ray = camera.ScreenPointToRay(screenCenter);

        RaycastHit hit;
        
        if(!Physics.Raycast(ray, out hit)) return;
        
        if(!hit.collider.CompareTag(enemyTag)) return;

        hit.collider.GetComponent<ReactiveTarget>().ReactToHit(damage);
    }
}
