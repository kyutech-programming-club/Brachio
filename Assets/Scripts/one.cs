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
    void Update()
    {
        if (push == false && button.push == true)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
    public void OnClickButton()
    {
        if (push == false && button.push == true)
        {
            push = true;
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
