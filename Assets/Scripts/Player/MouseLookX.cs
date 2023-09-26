using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookX : MonoBehaviour
{
    public float mouseXSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis ("Mouse X")*mouseXSpeed;
        
        
        Vector3 rot = new Vector3(0, mouseX, 0)*Time.deltaTime;
        transform.Rotate(rot);
    }
}
