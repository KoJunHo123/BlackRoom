using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;


public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Transform GunMuzzle;
    [SerializeField] GameObject Bullet;
    public Animator m_Animator;

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
            Instantiate(Bullet, GunMuzzle.position, GunMuzzle.transform.rotation);
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
