using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostOXGet : MonoBehaviour
{
    StageManager5 Manager;
    Spawn Spawner;
    int GetCount=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Manager = FindObjectOfType<StageManager5>();
        Spawner = FindObjectOfType<Spawn>();
        Debug.Log(Spawner.WrongCount + "WC");
        Debug.Log(Manager.i + "i");
        if (Spawner.WrongCount == GetCount && Manager.i == 12)
            Manager.GameClear = true;

    }
    private void OnTriggerEnter(Collider other)
    {
        Manager = FindObjectOfType<StageManager5>();
        if (other.gameObject.tag == "Answer")
        {
            Manager.GameOver = true;
            Destroy(other.gameObject);
        }
         if (other.gameObject.tag == "Wrong")
        {
            GetCount++;
            Destroy(other.gameObject);
        }
    }
}
