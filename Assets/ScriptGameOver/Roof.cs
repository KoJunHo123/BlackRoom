using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof : MonoBehaviour
{
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
        other.GetComponent<SphereCollider>().enabled = false;
        other.gameObject.AddComponent<BoxCollider>();
        //other.gameObject.GetComponent<BoxCollider>().center = new Vector3(0, 2, 0);
    }
    private void OnTriggerStay(Collider other)
    {
        other.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
