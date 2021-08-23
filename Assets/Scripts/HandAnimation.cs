using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour
{
    public bool Grabplayer;
    public bool GrabEnd;
    Animator animator;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Grabplayer)
        {
            timer += Time.deltaTime;
            GrabPlayer();
            if (timer > 1.0f)
                GrabEnd = true;
        }
    }

    public void GrabPlayer()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("Thumb", 1f);
        animator.SetFloat("Index", 1f);
        animator.SetFloat("Middle", 1f);
        animator.SetFloat("Ring", 1f);
        animator.SetFloat("Pinky", 1f);
    }
}
