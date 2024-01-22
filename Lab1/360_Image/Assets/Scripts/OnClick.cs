using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public Button myButton;

    private bool isButtonPressed;

    void Start()
    {
        // Attach an event handler to the button's onclick event
        myButton.onClick.AddListener(OnButtonDown);
    }

    void Update()
    {
        // Check if the button is still being pressed
        if (isButtonPressed)
        {
            // Code to execute continuously while the button is pressed
            Debug.Log("Button is being held down.");
        }
    }

    // Method called when the button is pressed
    public void OnButtonDown()
    {
        // Set the flag to indicate the button is being pressed
        isButtonPressed = true;

        // Start the coroutine to perform the continuous action
        StartCoroutine(ContinuousAction());
    }

    // Method called when the button is released
    public void OnButtonUp()
    {
        // Reset the flag when the button is released
        isButtonPressed = false;
    }

    // Coroutine for continuous action while the button is pressed
    private IEnumerator ContinuousAction()
    {
        while (isButtonPressed)
        {
            // Code to execute continuously while the button is pressed
            Debug.Log("Continuous action while the button is pressed.");

            // Yield a frame to allow other processes to execute
            yield return null;
        }
    }
}