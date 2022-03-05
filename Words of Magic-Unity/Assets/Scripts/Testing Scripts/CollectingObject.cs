using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectingObject : MonoBehaviour
{
    public GameObject FirstPageFLBt;
    public GameObject ObjectPoint;
    void Awake()
    {
        Transform launchPointTrans = transform.Find("ObjectPoint");
        ObjectPoint = launchPointTrans.gameObject;    
        ObjectPoint.SetActive(false);                                         
    }
    public void OnMouseEnter()
    {
        //print("Slingshot:OnMouseEnter()");
        ObjectPoint.SetActive(true);                                           // b
    }

    public void OnMouseExit()
    {
        //print("Slingshot:OnMouseExit()");
        ObjectPoint.SetActive(false);                                          // b
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
            FirstPageFLBt.SetActive(true);
        }
    }
}
