using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    StageManager5 stage5;
    void Start()
    {
        stage5 = FindObjectOfType<StageManager5>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Answer")
        {
            Destroy(other.gameObject);
            stage5.GameOver = true;
        }
        if (other.gameObject.tag == "Wrong")
        {
            Destroy(other.gameObject);
        }
    }

}
