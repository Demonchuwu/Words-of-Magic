/**** 
 * Created by:  Cristian Misla
 * Date Created: Mar 6, 2022
 * 
 * Last Edited by: Cristian Misla
 * Last Edited: Mar 7, 2022
 * 
 * Description: Instruction/text box that appears when clicked on.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu_Instructions : MonoBehaviour
{
    public GameObject panel;
    public bool off = false;
    public void OpenPanel()
    {
        Debug.Log("CLICKED");
        if(panel.activeSelf)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
}
