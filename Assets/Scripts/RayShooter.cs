using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    [SerializeField] private new Camera camera;
    [SerializeField] private string enemyTag = "Enemy";
    [SerializeField] private int damage = 100;
    [SerializeField] private GameObject projPrefab;
    

    // Update is called once per frame
    void Update()
    {
        checkMouseInput();
    }
    
    void checkMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);

            Ray ray = camera.ScreenPointToRay(screenCenter);

            RaycastHit hit;

            if (!Physics.Raycast(ray, out hit)) return;

            if (!hit.collider.CompareTag(enemyTag)) return;

            hit.collider.GetComponent<ReactiveTarget>().ReactToHit(damage);
        } else if (Input.GetMouseButtonDown(1))
        {
            var screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);

            Ray ray = camera.ScreenPointToRay(screenCenter);

            GameObject proj = Instantiate(projPrefab) as GameObject;
            proj.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
            proj.transform.rotation = transform.rotation;
        }
    }
}
