using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookY : MonoBehaviour
{
    public float mouseYSpeed = 3;
    private float _vertRot = 0;
    public float minY = -90;
    public float maxY = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y")*mouseYSpeed;
        
        
        _vertRot -= mouseY * Time.deltaTime;
//        Vector3 rot = new Vector3(-mouseY, 0, 0)*Time.deltaTime;
        
        _vertRot = Mathf.Clamp(_vertRot, minY, maxY);

        transform.localEulerAngles = new Vector3(_vertRot, 0, 0);
    }
}
