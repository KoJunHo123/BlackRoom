using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableMove : MonoBehaviour
{
    public Transform StartPoint;
    public Transform EndPoint;
    public bool buttonPressed;
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        if (buttonPressed == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, speed * Time.deltaTime);
        }
        if (buttonPressed == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, StartPoint.position, speed * Time.deltaTime);
        }
    }


}
