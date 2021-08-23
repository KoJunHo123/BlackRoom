using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject Wall2;

    public Transform Center;

    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Wall1.transform.position = Vector3.MoveTowards(Wall1.transform.position, Center.position, speed * Time.deltaTime);
        Wall2.transform.position = Vector3.MoveTowards(Wall2.transform.position, Center.position, speed * Time.deltaTime);
    }
}
