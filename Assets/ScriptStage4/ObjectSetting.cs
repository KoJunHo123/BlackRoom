using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetting : MonoBehaviour
{
    public bool SameOrDiff; //true:������ü false:�ٸ���ü
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

            if (SameOrDiff == false)
            {
                StageManager.count--;
                Destroy(other);
                Destroy(gameObject);
            }
            else StageManager.GameOver = true;
        }
    }
}
