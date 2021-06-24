using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //Rotational Speed
    public float speed = 0f;
    public float speedForwardX = 1f;
    public float speedForwardY = 1f;
    public float speedForwardZ = 1f;
    public float speedReverseX = 1f;
    public float speedReverseY = 1f;
    public float speedReverseZ = 1f;
    //Forward Direction
    public bool ForwardX = false;
    public bool ForwardY = false;
    public bool ForwardZ = false;

    //Reverse Direction
    public bool ReverseX = false;
    public bool ReverseY = false;
    public bool ReverseZ = false;

    void Update()
    {
        //Forward Direction
        if (ForwardX == true)
        {
            transform.Rotate(Time.deltaTime * speed * speedForwardX, 0, 0, Space.Self);
        }
        if (ForwardY == true)
        {
            transform.Rotate(0, Time.deltaTime * speed * speedForwardY, 0, Space.Self);
        }
        if (ForwardZ == true)
        {
            transform.Rotate(0, 0, Time.deltaTime * speed * speedForwardZ, Space.Self);
        }
        //Reverse Direction
        if (ReverseX == true)
        {
            transform.Rotate(-Time.deltaTime * speed * speedReverseX, 0, 0, Space.Self);
        }
        if (ReverseY == true)
        {
            transform.Rotate(0, -Time.deltaTime * speed * speedReverseY, 0, Space.Self);
        }
        if (ReverseZ == true)
        {
            transform.Rotate(0, 0, -Time.deltaTime * speed * speedReverseZ, Space.Self);
        }

    }
}
