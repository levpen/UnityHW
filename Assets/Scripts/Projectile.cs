using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 100.0f;
    public int damage = 100;
    [SerializeField] private string enemyTag = "Enemy";
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(enemyTag))
        {
            other.GetComponent<ReactiveTarget>().ReactToHit(damage);
        }
        Destroy(this.gameObject);
    }
}
