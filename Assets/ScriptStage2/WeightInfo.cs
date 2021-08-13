using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightInfo : MonoBehaviour
{
    StageManager2 Manager;
    ScaleRotate Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Manager = FindObjectOfType<StageManager2>();
        Speed = FindObjectOfType<ScaleRotate>();
        if (Manager.DestroyWeight)
        {
            Destroy(gameObject);
        }
    }
}
