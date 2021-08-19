using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof : MonoBehaviour
{
    [SerializeField] GameObject MachineGun;
    [SerializeField] GameObject DieText;
    bool intheroom;
    float timer;
    public float getTime; //머신건 발사 전 연출의 시간
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (intheroom)
            timer += Time.deltaTime;
        if (timer > getTime)
            MachineGun.GetComponent<MuchineGunRotate>().enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        DieText.GetComponent<TypingEffect>().enabled = true;
        other.GetComponent<SphereCollider>().enabled = false;
        other.gameObject.AddComponent<BoxCollider>();
        //MachineGun.GetComponent<MuchineGunRotate>().enabled = true;
        intheroom = true;
    }
    private void OnTriggerStay(Collider other)
    {
        other.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
