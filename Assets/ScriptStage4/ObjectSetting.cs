using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetting : MonoBehaviour
{
    public bool SameOrDiff; //true:같은물체 false:다른물체
    StageManager4 StageManager;
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
        if (other.gameObject.tag == "Bullet")
        {

            Debug.Log("맞음123123a");
            if (SameOrDiff == false)
            {
                Debug.Log("맞음");
                StageManager.count--;
                Destroy(gameObject);
            }
            else StageManager.GameOver = true;
        }
    }
}
