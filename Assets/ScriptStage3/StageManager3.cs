using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager3 : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
