using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    [SerializeField] AudioSource WindSound;
    public float timer;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 3.5f)
        {
            WindSound.volume -= Time.deltaTime / 4f;
            if (timer > 6.5f)
                WindSound.volume = 0.25f;
        }
    }
}
