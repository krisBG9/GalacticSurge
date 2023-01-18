using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class RestartScene : MonoBehaviour
{
    // Assign the button in the inspector
    public Button button;

    private void Start()
    {
        // Add a listener to the button's OnClick event
        button.onClick.AddListener(Restart);
    }

    // This function will be called when the button is clicked
    public void Restart()
    {
        // Get the current scene index
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the scene by its index
        SceneManager.LoadScene(sceneIndex);
    }
}
