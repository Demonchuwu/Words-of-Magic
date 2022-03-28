/**** 
 * Created by:  Cristian Misla
 * Date Created: Feb 28, 2022
 * 
 * Last Edited by: Cristian Misla
 * Last Edited: Mar 6, 2022
 * 
 * Description: Puzzle GameManager
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{

    /* Objects that get turned into buttons*/
    public GameObject FL_List_1;
    public GameObject FL_List_2;
    public GameObject Numbering;

    public InputField playerNameInput; //Inputfield for typing in game

    /* Cameras */
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;

    /* Objects that get destroyed */
    public GameObject Rocks;
    public GameObject Door;

    /* Buttons that move the cameras */
    public GameObject MovementBt;
    public GameObject MovementBt_two;

    /* bools in that determine if the puzzle was completed or not */
    public bool completed_One = false;
    public bool completed_Two = false;
    public bool completed_Three = false;

    /* Strings that get set in inspector for the puzzle answer */
    public string PuzzleOne;
    public string PuzzleTwo;
    public string PuzzleThree;
    [HideInInspector]
    public string playerName;
    GameManager gm;
    void Start()//activates code at the start of the game
    {
        gm = GameManager.GM; //find the game manager
        Cam1.SetActive(true); //enable cam1
        Cam2.SetActive(false);//disable cam2
        Cam3.SetActive(false);//disable cam3
    }//end Start()

    public void FL_One() //This allows the player to open and close the panel holding the first list of fake Languages
    {
        if (FL_List_1.activeSelf)//If the object is active
        {
            FL_List_1.SetActive(false);//Hide the object
        }//end if (FL_List_1.activeSelf)
        else//or if it is not
        {
            FL_List_1.SetActive(true);//Show the object
        }//end else
    }//end FL_One()

    public void FL_Two() //This allows the player to open and close the panel holding the Last list of fake Languages
    {
        if (FL_List_2.activeSelf)//If the object is active
        {
            FL_List_2.SetActive(false);//Hide the object
        }//end if (FL_List_2.activeSelf)
        else//or if it is not
        {
            FL_List_2.SetActive(true);//Show the object
        }//end else
    }//end FL_Two()

    public void Num_show() //This allows the player to open and close the panel holding the list of numbers to letters
    {
        if (Numbering.activeSelf) //If the object is active
        {
            Numbering.SetActive(false); //Hide the object
        }//end if (Numbering.activeSelf)
        else //or if it is not
        {
            Numbering.SetActive(true); //Show the object
        }//end else
    }//end Num_show()

    public void SetInput()
    {
        playerName = playerNameInput.text.ToLower(); //player's text = player name
        Floor(); //run puzzle one
        if (completed_One == true)//if the puzzle one is complete
        {
            Puzzle2();//run puzzle two
        }//end if (complete_One == true)
        if (completed_Two == true)//if puzzle two is complete
        {
            Puzzle3();//run puzzle three
        }//end if (complete_Two == true)
        if (completed_Three == true)//if puzzle three is complete
        {
            gm.NextLevel(); //Starts the next level.
        }//end if (complete_ == true)
    }//end SetInput()
    
    public void Floor()
    {
        if (Cam1.activeInHierarchy && playerName == PuzzleOne) //if the camera one is active and the player's input is matching puzzle one
        {
            Destroy(Rocks); //destroy gameobject rocks
            playerNameInput.text = ""; //reset the input text
            MovementBt.SetActive(true);//activate MovementBt
            completed_One = true;//complete puzzle one
            Debug.Log("Puzzle one is Completed");
        }//end if(Cam1.activeInHierarchy && playerName == PuzzleOne)
    }//end Floor()
    public void Puzzle2()
    {
        if (Cam2.activeInHierarchy && playerName == PuzzleTwo) //if camera 2 is active and player input matches puzzletwo
        {
            Destroy(GameObject.FindGameObjectWithTag("RemoveCube"));//destroy gameobject in game called Cube
            playerNameInput.text = "";//reset input text
            completed_Two = true;//complete puzzle two
            MovementBt.SetActive(false);//disable MovementBt
            MovementBt_two.SetActive(true);//enable MovementBt_Two
            Debug.Log("Puzzle two is Completed");
        }//end if (Cam2.activeInHierarchy && playerName == PuzzleTwo)
    }//end Puzzle2

    public void Puzzle3()
    {
        if (Cam3.activeInHierarchy && playerName == PuzzleThree)
        {
            Destroy(Door);//destroy gameobject door
            playerNameInput.text = "";//reset input text
            completed_Three = true;//complete puzzle three 
            Debug.Log("Puzzle Three is Completed");
        }//end if (Cam3.activeInHierarchy && playerName == PuzzleThree)
    }//end Puzzle3()

    public void RoomMove()//method to move camera 1 and 2
    {
        if (Cam1.activeSelf) //if cam1 is active
        {
            Cam1.SetActive(false);//set camera one to disabled
            Cam2.SetActive(true);//enable camera two
        }//end if (Cam1.activeSelf)
        else //or if cam2 is active.
        {
            Cam1.SetActive(true);//enable camera one
            Cam2.SetActive(false);//disable camera two
        }//end else
    }//end RoomMove()

    public void RoomMoveTwo()//method to move camera 2 to 3
    {
        Debug.Log("MOVE");
        if(completed_Two == true && Cam2.activeSelf)//if puzzle two is complete and cam2 is active
        {
            Cam1.SetActive(false);//disbale cam1
            Cam2.SetActive(false);//disable cam2
            Cam3.SetActive(true);//enable cam3
        }//end if(completed_Two == true && Cam2.activeSelf)

    }//end RoomMoveTwo()
    
    
   
}
