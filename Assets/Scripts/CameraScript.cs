using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class CameraScript : NetworkBehaviour
{
    // Start is called before the first frame update
    public Vector3 Pojition;
    public Quaternion quaternion;
    
    void Start()
    {
        transform.position = Pojition;
        transform.rotation = quaternion;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
