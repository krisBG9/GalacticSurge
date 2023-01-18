using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelPickUp : MonoBehaviour
{
    public int FuelAdd = 50;

    public GameObject player;
    
    void OnTriggerEnter2D (Collider2D PlObject) {
        if (PlObject.CompareTag("Player")){
            
            Pickup();
        }
    }

    void Pickup(){

        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.Fuel += FuelAdd;

        ResourceManager.instance.increaseFuel(FuelAdd);

        Destroy(gameObject);
    }

    
}
