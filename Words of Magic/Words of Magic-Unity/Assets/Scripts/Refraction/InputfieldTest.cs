using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System;

public class InputfieldTest : MonoBehaviour
{
    public TMP_InputField inputField;  // Reference to the InputField
    private InputAction activateInputFieldAction;  // Input Action for the key
    private List<string> commands = new List<string> { "fire", "spawn", "jump" };  // List of valid commands
    public GameObject Fire;
    public int seconds = 5;
    private void OnEnable()
    {
        // Get the input actions from the Input System
        var inputActions = new PlayerInputActions();  // Assuming you named your Input Action asset PlayerInputActions
        activateInputFieldAction = inputActions.UI.Type;  // Action for triggering input field activation

        // Enable the action to listen for input
        activateInputFieldAction.Enable();
    }

    private void OnDisable()
    {
        // Disable the action when this object is disabled
        activateInputFieldAction.Disable();
    }

    private void Update()
    {
        // Check if the / key is pressed to activate the InputField
        if (activateInputFieldAction.triggered)
        {
            Debug.Log("Activate Input Field Triggered");
            ActivateInputField();
        }
    }

    // Method to activate the InputField
    private void ActivateInputField()
    {
        inputField.ActivateInputField();
        inputField.Select();
    }

    // Method that will be called when the player submits the text
    public void SubmitText(string txt)
    {
        // Log the raw text input
        Debug.Log("Raw submitted text: '" + txt + "'");

        // Trim and convert to lowercase to make comparison easier
        txt = txt.Trim().ToLower();

        // Log the cleaned-up text
        Debug.Log("Cleaned-up submitted text: '" + txt + "'");

        // Check if the command is valid and not empty
        if (string.IsNullOrEmpty(txt))
        {
            Debug.Log("Text input is empty.");
            return;
        }

        if (commands.Contains(txt))
        {
            ExecuteCommand(txt);  // Execute the command if valid
        }
        else
        {
            Debug.Log("Invalid command: '" + txt + "'");  // Log an error if the command is invalid
        }

        inputField.text = "";  // Clear the input field after submitting
    }

    // Method to execute commands based on user input
    private void ExecuteCommand(string command)
    {
        Debug.Log("Executing command: " + command);
        switch (command)
        {
            case "fire":
                Debug.Log("FireCommandActive");
                StartCoroutine(FireCommand(seconds));
                break;

            case "spawn":
                Debug.Log("Spawning an object...");
                // Your spawn logic here, e.g., Instantiate an object
                break;

            case "jump":
                Debug.Log("Player jumps!");
                // Your jump logic here, e.g., make the player jump
                break;

            default:
                Debug.Log("Command not recognized.");
                break;
        }
    }

    private IEnumerator FireCommand(int seconds)
    {
        Debug.Log("Burn bright");
        Fire.SetActive(true);
        yield return new WaitForSeconds(seconds);
        Fire.SetActive(false);
    }
}