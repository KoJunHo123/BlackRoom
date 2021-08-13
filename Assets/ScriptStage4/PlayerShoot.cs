using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Transform GunMuzzle;
    [SerializeField] GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shooting()
    {
        Instantiate(Bullet, GunMuzzle.position, Bullet.transform.rotation);
    }
}
