using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCheckMass : MonoBehaviour
{
    public int Mass;
    ScaleRotate Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Mass);
    }
    private void OnTriggerEnter(Collider other)
    {
        Speed = FindObjectOfType<ScaleRotate>();
        if (other.gameObject.tag == "Answer")
            Mass += 9;
        else Mass += 10;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Answer")
            Mass -= 9;
        else Mass -= 10;

    }
}
