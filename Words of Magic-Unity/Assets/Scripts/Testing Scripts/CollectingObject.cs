using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectingObject : MonoBehaviour
{
    public GameObject FirstPageFLBt;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
            FirstPageFLBt.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
