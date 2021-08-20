using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneeze : MonoBehaviour 
{
    [SerializeField] AudioSource kc;
    public float RemainTime;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    
    }
    // Update is called once per frame
    void Update()
    {
        RemainTime += Time.deltaTime;
        if(RemainTime > 10.0f)
        {
            kc.Play();
            RemainTime = 0;
        }
        
    }
}
