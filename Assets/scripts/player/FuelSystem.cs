using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSystem
{
    // fuel tank size (in liters)
    public float fuelTankSize = 50f;

    // current fuel level (in liters)
    public float fuelLevel = 50f;

    // fuel burn rate (in liters/second)
    public float fuelBurnRate = 10f;

    // Update is called every frame
    void Update()
    {
        // consume fuel based on burn rate
        fuelLevel -= fuelBurnRate * Time.deltaTime;

        // check if fuel has run out
        if (fuelLevel <= 0f)
        {
            fuelLevel = 0f;
            Debug.Log("Fuel has run out!");
        }
    }

    // refill fuel tank
    public void RefillFuel(float amount)
    {
        fuelLevel += amount;

        // make sure fuel doesn't exceed tank size
        fuelLevel = Mathf.Min(fuelLevel, fuelTankSize);
    }
}

/*
This code defines a FuelSystem class with a fuel tank size, current fuel level,
and fuel burn rate. The Update function is called every frame, and it decreases
the fuel level by the burn rate multiplied by the time since the last frame. 
The RefillFuel function can be called to increase the fuel level by a certain amount.

Sure! Here's a simple fuel burning system that you can use in the Unity game engine:

First, create a fuel tank object and a fuel burn rate variable. The fuel tank will store the amount of fuel remaining, and the fuel burn rate will determine how quickly the fuel is consumed.

Next, create a fuel consumption function that decreases the fuel tank by the fuel burn rate every frame. This function should be called every frame in the game update loop.

You can also add a check to make sure that the fuel tank doesn't go below zero, and display a message or trigger some other event when the fuel runs out.

To refill the fuel tank, you can create a function that increases the fuel tank by a certain amount. This function can be called when the player interacts with a fuel station or picks up a fuel can.
*/
