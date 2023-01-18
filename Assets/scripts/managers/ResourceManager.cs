using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ResourceManager : MonoBehaviour
{
    public static ResourceManager instance;

    public TMP_Text fuelAmount;

    public TMP_Text moneyAmount;

    public GameObject PlayerStats;

    public float FAmount = 100;
    public int MAmount = 100;

    void Awake(){
        instance = this;
       
    }

    void Update(){
        fuelAmount.text = FAmount.ToString("f0");
        moneyAmount.text = MAmount.ToString();
    }
    public void increaseFuel(float fuel){

        FAmount += fuel;

        fuelAmount.text = FAmount.ToString();

    }

    public void increaseMoney(int money){

        MAmount += money;

        moneyAmount.text = MAmount.ToString();

    }
   
}
