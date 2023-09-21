using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void updateHealth(int damage) {
        health -= damage;
        if(health <= 0) {
            Destroy(this);
            Debug.Log("Dead");
        }
        Debug.Log("hit");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
