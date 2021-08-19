using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MachineGunManager : MonoBehaviour
{
    [SerializeField] AudioSource SpinStart;
    [SerializeField] AudioSource SpinLoop;
    [SerializeField] AudioSource FireStart;
    [SerializeField] AudioSource FireLoop;
    [SerializeField] GameObject MachineGun;
    [SerializeField] GameObject FadeOut;
    [SerializeField] Transform BarrelEnd;
    [SerializeField] ParticleSystem[] Particle;
    bool spinstart;
    bool spinloop;
    bool firestart;
    bool fireloop;
    float timer;
    float Blank;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (MachineGun.GetComponent<MuchineGunRotate>().enabled && !spinstart)
        {
            SpinStart.Play();
            spinstart = true;
        }
        else if (!SpinStart.isPlaying && !spinloop && spinstart)
        {
            SpinLoop.Play();
            spinloop = true;
        }
        else if (MachineGun.GetComponent<MuchineGunRotate>().speed > 1500f && !firestart && spinloop)
        {
            FireStart.Play();
            firestart = true;
        }
        else if (FireStart.isPlaying && !fireloop && firestart)
        {
            SpinLoop.volume = 0.3f;
            FireLoop.Play();
            FadeOut.SetActive(true);
            fireloop = true;
        }
        if (fireloop)
        {
            int i = 0;
            timer += Time.deltaTime;
            Blank += Time.deltaTime;
            for (i = 0; i < Particle.Length; i++)
            {
                if (!Particle[i].isPlaying)
                    Particle[i].Play();
            }
            SpinLoop.volume -= Time.deltaTime / 7f;
            FireLoop.volume -= Time.deltaTime / 7f;
            
        }
        if (timer > 8.0f)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
}
