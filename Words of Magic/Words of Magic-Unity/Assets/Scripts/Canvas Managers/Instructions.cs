/**** 
 * Created by:  Cristian Misla
 * Date Created: Mar 6, 2022
 * 
 * Last Edited by: Cristian Misla
 * Last Edited: Mar 6, 2022
 * 
 * Description: Instruction/text box that appears when clicked on.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public string Tip; //String that needs to be typed in the inspector
    public Text Insert;//UI Text in the canvas
    public GameObject TextBox;//Panel used as a text box
    public GameObject ObjectPoint;//GameObject that holds the halo affect

    public void OnMouseOver()//method that activates when the object is hovered on.
    {
        if (Input.GetMouseButtonDown(0))//if the mouse left clicks on the object
        {
            TextBox.SetActive(true);//activate textbox
            Insert.text = Tip;
        }//end if (Input.GetMouseButtonDown(0))
    }//end OnMouseOver()

    void Awake()//called when the script is being loaded
    {
        Transform launchPointTrans = transform.Find("ObjectPoint"); 
        ObjectPoint = launchPointTrans.gameObject;
        ObjectPoint.SetActive(false);//disables the objectpoint
        TextBox.SetActive(false); //disables the text box at the start
    }//end Awake()
    
    public void OnMouseEnter() //method that activates when the mouse enters the collider area
    {
        ObjectPoint.SetActive(true);//enables the objectpoint
    }//end OnMouseEnter()

    public void OnMouseExit()
    {
        ObjectPoint.SetActive(false);//disables the objectpoint
    }//end OnMouseExit()

    public void TextArea()
    {
        TextBox.SetActive(true);//enables the textbox
        Insert.text = Tip;//turns the text in the inspector to the text on the canvas
        Close();//calls the Close Method
    }//end TextArea()
    public void Close()
    {
        TextBox.SetActive(false);//closes the textbox
    }//end Close()
}
