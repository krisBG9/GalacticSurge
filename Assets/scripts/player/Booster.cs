using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] GameObject ResManager;

    [SerializeField] ParticleSystem engineFlame = null;

     private Rigidbody2D spaceshipRigidbody;

     public float thrusterforce = 5f;

     public bool burntime = false;
     public float fuelburn = 1;

    private void Awake(){
        spaceshipRigidbody = transform.parent.GetComponent<Rigidbody2D>();

        engineFlame.Stop();
    }
    private void Update() {
        float fAmount = ResManager.GetComponent<ResourceManager>().FAmount;
        if (Input.GetKey(KeyCode.W) && fAmount >= 0 ){

            fAmount -= fuelburn * Time.deltaTime;
            ResManager.GetComponent<ResourceManager>().FAmount = fAmount;

            spaceshipRigidbody.AddForceAtPosition (transform.up * thrusterforce, transform.position, ForceMode2D.Force ) ;

                          
        }

        if (Input.GetKeyDown(KeyCode.W) && fAmount >= 0 ){
            engineFlame.Play();
            burntime = false;
            //Debug.Log(burntime);
           
        }
        if (Input.GetKeyUp(KeyCode.W)){
            
            engineFlame.Stop();
            burntime = false;
            StopAllCoroutines();
            
        }
    }

    
}
