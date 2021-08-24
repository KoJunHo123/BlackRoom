using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingSound : MonoBehaviour
{
    [SerializeField] AudioSource hitAudioPlayer;


    public ParticleSystem DustEffect;
    public float timer1;
    public float timer2;
    public float timer3;
    public float hittingTime;
    public float BoomTime;
    public float hitTerm;
    float i;

    public Transform hitArea;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;

        if (timer1 > hittingTime)
        {
            if (timer2 > hitTerm)
            {
                hitAudioPlayer.Play();
                timer2 = 0;
            }
            
        }
        if(timer1 > BoomTime)
        {
            if (timer3 > hitTerm)
            {
                Instantiate(DustEffect, hitArea.position, Quaternion.Euler(0, 0, 0));
                timer3 = 0;
            }
        }


    }
}
