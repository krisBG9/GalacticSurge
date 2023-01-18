using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private Rigidbody2D  Fuelpick;
    [SerializeField] private Rigidbody2D Moneypick;
    [SerializeField] private int health;

    //private int health = 100;

    private float randomDirection, randomSpeed;

    //public GameObject Fuelpick;
    //public GameObject Moneypick;

    public void TakeDamage (int damage){
        health -= damage;

        if (health <= 0){
            Die();
        }
    }
    
    void Die (){

        var FpickUp = Instantiate(Fuelpick, transform.position, transform.rotation);
        var MpickUp = Instantiate(Moneypick, transform.position, transform.rotation);
        randomDirection = Random.Range (-0.5f, 0.5f);
        randomSpeed = Random.Range (1f, 5f);
        FpickUp.AddForce(new Vector2(0f + randomDirection, -1f) * randomSpeed, ForceMode2D.Impulse);
        MpickUp.AddForce(new Vector2(0f + randomDirection, 1f) * randomSpeed, ForceMode2D.Impulse);
        Destroy(gameObject);
    }
}
