using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRun : MonoBehaviour
{
    public Transform AttackPoint;
    public Animator m_Animator;
    [SerializeField] ParticleSystem BloodParticle;

    public bool walking = true;
    public float speed;
    public float delta;

    void Start()
    {

    }

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > 3)
            transform.position = Vector3.MoveTowards(transform.position, AttackPoint.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Jump")
        {
            Debug.Log("1");
            m_Animator.SetTrigger("Jump");
        }
        if(other.gameObject.tag == "Attack")
        {
            Debug.Log("2");
            m_Animator.SetTrigger("Attack");
            Instantiate(BloodParticle, transform.position, Quaternion.LookRotation(Vector3.up));
        }
    }


}
