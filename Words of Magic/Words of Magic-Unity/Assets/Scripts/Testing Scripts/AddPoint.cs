/**** 
 * Created by: Akram Taghavi-Burrs
 * Date Created: Feb 23, 2022
 * 
 * Last Edited by: Cristian Misla
 * Last Edited: Mar 6, 2022
 * 
 * Description: Check for score update [TESTINGS ONLY]
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TEST SCRIPT FOR CHECKING SCORE UPDATE
public class AddPoint : MonoBehaviour
{
    public float time = 0.00f; 

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;


    }//end Update()
}
