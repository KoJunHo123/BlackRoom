using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMove : MonoBehaviour
{
    public float timer;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3.0f)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

    }
}
