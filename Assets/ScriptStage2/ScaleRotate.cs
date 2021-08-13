using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleRotate : MonoBehaviour
{
    [SerializeField] GameObject Stick;
    [SerializeField] GameObject LeftScale;
    [SerializeField] GameObject RightScale;
    public bool isLeftHeavy;
    public bool isRightHeavy;
    public float speed = 100f;
    public float UpDowndelta;
    public float LRdelta;
    public bool LeftEnd;
    public bool RightEnd;
    float UpDownInfo;
    float LRInfo;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLeftHeavy)
        {
            LeftHeavy();
        }
        if (isRightHeavy)
        {
            RightHeavy();
        }

        if (LeftEnd)
        {
            Stick.transform.rotation = new Quaternion(0, 0, 0, 0);
            LeftScale.transform.position = new Vector3(LeftScale.transform.position.x - LRInfo, LeftScale.transform.position.y + UpDownInfo, LeftScale.transform.position.z);
            RightScale.transform.position = new Vector3(RightScale.transform.position.x + LRInfo, RightScale.transform.position.y - UpDownInfo, RightScale.transform.position.z);
            LeftEnd = false;
            
            isLeftHeavy = false;
            speed = 100f;
            timer = 0;
        }
        else if(RightEnd)
        {
            Stick.transform.rotation = new Quaternion(0, 0, 0, 0);
            LeftScale.transform.position = new Vector3(LeftScale.transform.position.x + LRInfo, LeftScale.transform.position.y - UpDownInfo, LeftScale.transform.position.z);
            RightScale.transform.position = new Vector3(RightScale.transform.position.x - LRInfo, RightScale.transform.position.y + UpDownInfo, RightScale.transform.position.z);
            RightEnd = false;
            isRightHeavy = false;
            speed = 100f;
            timer = 0;
        }

    }

    public void LeftHeavy()
    {
        Vector3 Delta = LeftScale.transform.position;
        Stick.transform.Rotate(0, 0, Time.deltaTime * speed);
        LeftScale.transform.position = Vector3.Lerp(LeftScale.transform.position, new Vector3(LeftScale.transform.position.x + LRdelta, LeftScale.transform.position.y - UpDowndelta, LeftScale.transform.position.z), speed * Time.deltaTime * 0.1f);
        RightScale.transform.position = Vector3.Lerp(RightScale.transform.position, new Vector3(RightScale.transform.position.x- LRdelta, RightScale.transform.position.y + UpDowndelta, RightScale.transform.position.z), speed*Time.deltaTime*0.1f);
        speed *= 0.96f;
        UpDownInfo += Mathf.Abs(LeftScale.transform.position.y - Delta.y);
        LRInfo += Mathf.Abs(LeftScale.transform.position.x - Delta.x);
        if (speed < 0.01f)
        {
            speed = 0;
            timer += Time.deltaTime;
            if(timer > 5.0f)
                LeftEnd = true;
        }
    }
    public void RightHeavy()
    {
        Vector3 Delta = LeftScale.transform.position;
        Stick.transform.Rotate(0, 0, -Time.deltaTime * speed);
        LeftScale.transform.position = Vector3.Lerp(LeftScale.transform.position, new Vector3(LeftScale.transform.position.x - LRdelta, LeftScale.transform.position.y + UpDowndelta, LeftScale.transform.position.z), speed * Time.deltaTime * 0.1f);
        RightScale.transform.position = Vector3.Lerp(RightScale.transform.position, new Vector3(RightScale.transform.position.x + LRdelta, RightScale.transform.position.y - UpDowndelta, RightScale.transform.position.z), speed * Time.deltaTime * 0.1f);
        speed *= 0.96f;
        UpDownInfo += Mathf.Abs(LeftScale.transform.position.y - Delta.y);
        LRInfo += Mathf.Abs(LeftScale.transform.position.x - Delta.x);
        if (speed < 0.01f)
        {
            speed = 0;
            timer += Time.deltaTime;
            if (timer > 5.0f)
                RightEnd = true;
        }
    }
}
