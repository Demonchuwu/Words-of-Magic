using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class InputfieldTest : MonoBehaviour
{
    public TMP_InputField inputField;  // Reference to the InputField
    private InputAction activateInputFieldAction;  // Input Action for the / key

    private void OnEnable()
    {
        // Get the input actions from the Input System
        var inputActions = new PlayerInputActions();  // Assuming you named your Input Action asset PlayerInputActions
        activateInputFieldAction = inputActions.UI.Type;

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
        // Check if the / key is pressed
        if (activateInputFieldAction.triggered)
        {
            ActivateInputField();
        }
    }

    // Method to activate the InputField
    private void ActivateInputField()
    {
        inputField.ActivateInputField();
        inputField.Select();
    }
}
