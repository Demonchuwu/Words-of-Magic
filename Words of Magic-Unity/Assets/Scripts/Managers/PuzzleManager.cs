/**** 
 * Created by:  Cristian Misla
 * Date Created: Feb 28, 2022
 * 
 * Last Edited by: Cristian Misla
 * Last Edited: Feb 28, 2022
 * 
 * Description: Puzzle GameManager
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public GameObject FL_List_1;


    public void Pan()
    {
        if (FL_List_1.activeSelf)
        {
            FL_List_1.SetActive(false);
        }
        else
        {
            FL_List_1.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
