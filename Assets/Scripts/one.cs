using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class one : MonoBehaviour
{
    public bool push = false;
    public zero button;
    
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    // Start is called before the first frame update
    public void OnClickButton()
    {
        if (push == false && button.push == true)
        {
            push = true;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
