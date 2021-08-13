using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    StageManager5 Manager;
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
        Manager = FindObjectOfType<StageManager5>();
        if (other.gameObject.tag == "Answer")
            Destroy(other);
        else Manager.GameOver = true;
    }
}
