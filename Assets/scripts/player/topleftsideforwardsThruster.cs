using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topleftsideforwardsThruster : MonoBehaviour
{
    [SerializeField] GameObject ResManager;
    [SerializeField] ParticleSystem engineFlame = null;
    private Rigidbody2D spaceshipRigidbody;

    public float thrusterforce = 5f;

    public float fuelburn = 1;

    public KeyCode keycode;

    private void Awake(){
        spaceshipRigidbody = transform.parent.GetComponent<Rigidbody2D>();
    }
    private void Update() {

        var fAmount = ResManager.GetComponent<ResourceManager>().FAmount;

        if (Input.GetKey(keycode) && fAmount >= 0 ){
            
            spaceshipRigidbody.AddForceAtPosition (transform.up * thrusterforce, transform.position, ForceMode2D.Force ) ;
            
            fAmount -= fuelburn * Time.deltaTime;
            ResManager.GetComponent<ResourceManager>().FAmount = fAmount;
        }
        if (Input.GetKeyDown(keycode) && fAmount > 0 ){
            
            engineFlame.Play();
        }
        if (Input.GetKeyUp(keycode)){
            
            engineFlame.Stop();
        }
    }
    
}
