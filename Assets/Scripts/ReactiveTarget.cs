using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    public int health = 100;
    public void ReactToHit(int damage)
    {
        Debug.Log("hit");
        health -= damage;
        if(health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
