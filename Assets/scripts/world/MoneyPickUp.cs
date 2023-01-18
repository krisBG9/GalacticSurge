using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickUp : MonoBehaviour
{
    public int MoneyAdd = 10;

    public GameObject player;
    
    void OnTriggerEnter2D (Collider2D PlObject) {
        if (PlObject.CompareTag("Player")){
            
            Pickup();
        }
    }

    void Pickup(){

        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.Money += MoneyAdd;

        ResourceManager.instance.increaseMoney(MoneyAdd);

        
        Destroy(gameObject);
    }

    
}
