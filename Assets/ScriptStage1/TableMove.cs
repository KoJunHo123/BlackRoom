using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableMove : MonoBehaviour
{
    public Transform StartPoint;
    public Transform EndPoint;
    public bool buttonPressed;
    public bool teleportButton;
    public float speed;
    public int count;
    bool Lock;
    [SerializeField] GameObject MoveButton;
    [SerializeField] GameObject TelButton;

    void Start()
    {

    }

    void Update()
    {
        if (buttonPressed || teleportButton)
        {
            if (!Lock)
            {
                if (buttonPressed)
                {
                    MoveButton.GetComponent<Rigidbody>().isKinematic = true;
                    TelButton.GetComponent<Rigidbody>().isKinematic = true;
                    moveEndFloor();
                    if (transform.position == EndPoint.position)
                    {
                        teleportButton = true;
                        MoveButton.GetComponent<Rigidbody>().isKinematic = false;
                        TelButton.GetComponent<Rigidbody>().isKinematic = false;
                        Lock = true;
                    }
                }
                else if (teleportButton)
                {
                    telEndFloor();
                    buttonPressed = true;
                    Lock = true;
                }
            }
            else
            {
                if (!buttonPressed)
                {
                    MoveButton.GetComponent<Rigidbody>().isKinematic = true;
                    TelButton.GetComponent<Rigidbody>().isKinematic = true;
                    moveStartFloor();
                    if (transform.position == StartPoint.position)
                    {
                        teleportButton = false;
                        MoveButton.GetComponent<Rigidbody>().isKinematic = false;
                        TelButton.GetComponent<Rigidbody>().isKinematic = false;
                        Lock = false;
                    }
                }
                else if (!teleportButton)
                {
                    telStartFloor();
                    buttonPressed = false;
                    Lock = false;
                }
            }
        }
        





    }
    //if (buttonPressed == true && teleportButton == false)
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, speed * Time.deltaTime);
    //    if (transform.position == EndPoint.position)
    //        teleportButton = true;

    //}
    //else if (teleportButton == true && buttonPressed == false)
    //{
    //    transform.position = EndPoint.position;
    //    if (transform.position == EndPoint.position)
    //        buttonPressed = true;
    //}
    //if (buttonPressed == false && teleportButton == true)
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, StartPoint.position, speed * Time.deltaTime);
    //    if (transform.position == StartPoint.position)
    //        teleportButton = false;

    //}
    //else if (teleportButton == false && buttonPressed == trye\)
    //{
    //    transform.position = EndPoint.position;
    //    if (transform.position == EndPoint.position)
    //        buttonPressed = true;
    //}






    void moveEndFloor()
    {
        transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, speed * Time.deltaTime);
    }
    void moveStartFloor()
    {
        transform.position = Vector3.MoveTowards(transform.position, StartPoint.position, speed * Time.deltaTime);
    }
    void telEndFloor()
    {
        transform.position = EndPoint.position;
    }
    void telStartFloor()
    {
        transform.position = StartPoint.position;
    }

}
