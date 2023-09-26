using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class test : MonoBehaviour
{
    public int[] nums;
    public float rotateSpeed = 30;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotateSpeed*Time.deltaTime, 0, 0));
    }
}
