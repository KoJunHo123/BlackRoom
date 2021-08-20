using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    StageManager5 stage5;
    Spawn spawn;
    int count;
    void Start()
    {
        stage5 = FindObjectOfType<StageManager5>();
        spawn = FindObjectOfType<Spawn>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Answer")
        {
            Destroy(other.gameObject);
            stage5.GameOver = true;
        }
        if (other.gameObject.tag == "Wrong")
        {
            Destroy(other.gameObject);
            count++;
            if (spawn.WrongCount == count)
                stage5.GameClear = true;
        }
    }

}
