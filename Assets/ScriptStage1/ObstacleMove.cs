using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float delta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 8.9f)
            transform.position = new Vector3(transform.position.x, transform.position. y + (Time.deltaTime* delta), transform.position.z);
    }
}
