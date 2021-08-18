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
    bool spinstart;
    bool spinloop;
    bool firestart;
    bool fireloop;
    float timer;
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
            timer += Time.deltaTime;
        if (timer > 8.0f)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
}
