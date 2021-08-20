using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEffect : MonoBehaviour
{
    GetAnswer Manager;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Manager = FindObjectOfType<GetAnswer>();
        if(Manager.GameOver)
        {
            transform.Rotate(-Vector3.forward * Time.deltaTime * speed);
            if (transform.rotation.eulerAngles.z < 320f)
                speed = 0;
        }
    }
}
