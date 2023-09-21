using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 Position;
    private int Health;


    private float PrevUpdate;
    
    void updateHealth(int delta) {
        Health += delta;
        if(Health <= 0) {
            Debug.Log("player died");
            Health = 0;
        }    
    }

    // Start is called before the first frame update
    void Start()
    {
        Position = transform.position;
        PrevUpdate = Time.time;
        Health = 1;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = Position;
        //Debug.Log(Health);
        if(Time.time-PrevUpdate > 2.0) {
            Position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            updateHealth(Random.Range(-10, 10));
            PrevUpdate = Time.time;
        }
    }
}
