using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBackgroundPos : MonoBehaviour
{    
    public GameObject shippos;

    void Update()
    {
       transform.position = shippos.transform.position;
    }
}
