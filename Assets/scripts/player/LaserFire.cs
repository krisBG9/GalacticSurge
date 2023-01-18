using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour
{
    
    public LineRenderer lineRenderer;
    public Transform firePoint;
    public Transform aimPoint;
    public Transform raycastOrigin;
    public int damage = 1;
    public GameObject endBeam;

    void Start()
    {
        DisableLaser();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            EnableLaser();
        }

        if(Input.GetKey(KeyCode.Space)) {
            UpdateLaser();
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            DisableLaser();

        }
    }

    void EnableLaser()
    {
        lineRenderer.enabled = true;
    }

    void DisableLaser(){
        lineRenderer.enabled = false;
        endBeam.SetActive(false);
    }

    void UpdateLaser() {


        lineRenderer.SetPosition(0, firePoint.position);
                RaycastHit2D hit = Physics2D.Raycast(raycastOrigin.position, transform.up);

        if(hit){
            lineRenderer.SetPosition(1, hit.point);

            Asteroid asteroid = hit.transform.GetComponent<Asteroid>();
            if (asteroid != null){
                asteroid.TakeDamage(damage);

                endBeam.SetActive(true);
                endBeam.transform.position = lineRenderer.GetPosition(1);
                
                
            }
        }

        

    }
}
