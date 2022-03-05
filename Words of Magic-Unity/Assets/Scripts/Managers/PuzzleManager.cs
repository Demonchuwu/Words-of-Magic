/**** 
 * Created by:  Cristian Misla
 * Date Created: Feb 28, 2022
 * 
 * Last Edited by: Cristian Misla
 * Last Edited: Mar 2, 2022
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
    public GameObject FL_List_2;
    public GameObject Numbering;
    public InputField playerNameInput;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Rocks;
    public GameObject MovementBt;
    public bool completed_One = false;
    [HideInInspector]
    public string playerName;
    
    public void FL_One()
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
    public void FL_Two()
    {
        if (FL_List_2.activeSelf)
        {
            FL_List_2.SetActive(false);
        }
        else
        {
            FL_List_2.SetActive(true);
        }
    }
    public void Num_show()
    {
        if (Numbering.activeSelf)
        {
            Numbering.SetActive(false);
        }
        else
        {
            Numbering.SetActive(true);
        }
    }

    public void SetInput()
    {
        playerName = playerNameInput.text;
        Floor();
    }

    public void Floor()
    {
        if (Cam1.activeInHierarchy && playerName == "Gall" || playerName == "gall")
        {
            Destroy(Rocks);
            playerNameInput.text = "";
            MovementBt.SetActive(true);
            completed_One = true;
            Debug.Log("Puzzle one is Completed");
        }
    }

    public void RoomMove()
    {
        if (Cam1.activeSelf)
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
        }
        else 
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
        }
    }

    void Start()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
    }
    
   
}
