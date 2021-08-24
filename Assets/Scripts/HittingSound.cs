using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingSound : MonoBehaviour
{
    [SerializeField] AudioSource hitAudioPlayer;
    public ParticleSystem DustEffect;
    public float timer1;
    public float timer2;
    public float hittingTime;
    public float hitTerm;
    float i;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (timer1 > hittingTime)
        {
            if (timer2 > hitTerm)
            {
                hitAudioPlayer.Play();
                timer2 = 0;
                DustEffect.Play();
                
            }

        }


    }
}
