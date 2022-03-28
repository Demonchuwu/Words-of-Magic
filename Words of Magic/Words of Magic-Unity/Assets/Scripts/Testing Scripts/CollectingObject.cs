/**** 
 * Created by:  Cristian Misla
 * Date Created: Mar 6, 2022
 * 
 * Last Edited by: Cristian Misla
 * Last Edited: Mar 6, 2022
 * 
 * Description: Collect object
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectingObject : MonoBehaviour
{
    /* GameObject to be inserted in inspector window */
    public GameObject FirstPageFLBt;
    
    public void OnMouseOver() //method to play when the mouse is over the object.
    {
        if (Input.GetMouseButtonDown(0))//if mouse right clicks on object
        {
            gameObject.SetActive(false);//disable the object
            FirstPageFLBt.SetActive(true);//enable the button
        }//end if (Input.GetMouseButtonDown(0))
    }//end OnMouseOver()
}
