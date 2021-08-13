using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetting : MonoBehaviour
{
    public bool SameOrDiff; //true:같은물체 false:다른물체
    StageManager4 StageManager;
    ScaleRotate ScaleState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        StageManager = FindObjectOfType<StageManager4>();
        ScaleState = FindObjectOfType<ScaleRotate>();
        if (other.gameObject.tag == "bullet")
        {
            if (SameOrDiff == false)
            {
                StageManager.count--;
                Destroy(gameObject);
            }
            else StageManager.GameOver = true;
        }
    }
}
