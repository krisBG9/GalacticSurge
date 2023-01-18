using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TurnOffParent : MonoBehaviour
{
     // Assign the button in the inspector
    public Button button;

    public GameObject offgameObject;

    private void Start()
    {
        // Add a listener to the button's OnClick event
        button.onClick.AddListener(TurnOff);
    }

    // This function will be called when the button is clicked
    public void TurnOff()
    {
        // Turn off the parent game object
        offgameObject.SetActive(false);
    }
}
