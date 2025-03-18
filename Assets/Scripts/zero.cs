using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class zero : MonoBehaviour
{
    public bool push = false;
    
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    // Start is called before the first frame update
    public void OnClickButton()
    {
        if (push == false)
        {
            push = true;
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
