using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordMove : MonoBehaviour
{
    public float speed;
    float delta=0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > 0.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Time.deltaTime * speed) ;
        }
    }
}
