using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixerPerson : MonoBehaviour
{
    Transform FirstPosition;
    // Start is called before the first frame update
    void Start()
    {
        FirstPosition = GetComponent<Transform>();
        FirstPosition.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = FirstPosition.position;
    }
}
