using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightInfo : MonoBehaviour
{
    StageManager2 Manager;
    ScaleRotate ScaleRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Manager = FindObjectOfType<StageManager2>();
        ScaleRot = FindObjectOfType<ScaleRotate>();
       /* if (ScaleRot.LeftEnd || ScaleRot.RightEnd)
        {
            if (gameObject.layer == 9)
                transform.position = new Vector3(transform.position.x - ScaleRot.LRInfo, transform.position.y + ScaleRot.UpDownInfo, transform.position.z);
            else if (gameObject.layer == 10)
                transform.position = new Vector3(transform.position.x + ScaleRot.LRInfo, transform.position.y - ScaleRot.UpDownInfo, transform.position.z);
        }*/
        if (Manager.DestroyWeight)
        {
            Destroy(gameObject);
        }
    }
}
