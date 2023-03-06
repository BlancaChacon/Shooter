using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed; 


    // Update is called once per frame
    void Update()
    {
        transform.Translate(x:0,y:0,z:speed*Time.deltaTime);
    }
}
