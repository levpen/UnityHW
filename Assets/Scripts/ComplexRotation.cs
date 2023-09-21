using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexRotation : MonoBehaviour
{
    public float speed = 5;
    public float angleSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, angleSpeed*Time.deltaTime, 0));
        transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
    }
}
