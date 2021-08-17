using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.UI;


public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Transform GunMuzzle;
    [SerializeField] GameObject Bullet;
    public Animator m_Animator;
    public ParticleSystem MuzzleEffect;

    public AudioSource GunAudioPlayer;

    public AudioClip ShotClip;

    public float time;
    public float count = 6;
    public bool gunShootCnotrol = true;
    bool istrigger;
    public XRController controller;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControllerInput();

        if (count == 0)
        {
            gunShootCnotrol = false;
        }
    }

    public void Shooting()
    {
        StartCoroutine(ShootTerm());
    }

    IEnumerator ShootTerm()
    {
        if (gunShootCnotrol == true)
        {
            MuzzleEffect.Play();
            if(GunAudioPlayer.clip != ShotClip)
            {
                GunAudioPlayer.clip = ShotClip;
            }

            GunAudioPlayer.Play();

            Instantiate(Bullet, GunMuzzle.position,GunMuzzle.rotation);
            count--;
            m_Animator.SetTrigger("Shot1");
            gunShootCnotrol = false;
        }
        yield return new WaitForSeconds(time);
        gunShootCnotrol = true;
    }
    void ControllerInput()
    {
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger))
        {
            if (trigger)
            {
                if (!istrigger)
                {
                    istrigger = true;
                    Shooting();
                }
            }
            else
            {
                istrigger = false;
            }
        }
    }


}
