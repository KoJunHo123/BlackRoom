using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightInfo : MonoBehaviour
{
    StageManager2 Manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Manager = FindObjectOfType<StageManager2>();
        if (Manager.DestroyWeight)
        {
            Destroy(gameObject);
        }
    }
}
