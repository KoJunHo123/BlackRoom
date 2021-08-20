using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fog : MonoBehaviour
{
    [SerializeField] Text RemainTimer;
    public float RemainTime;
    float Size = (3f/20f);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RemainTime -= Time.deltaTime;
        RemainTimer.text = "Time: " + (int)RemainTime + "s";
        if (transform.localScale.z < 10f)
        transform.localScale = new Vector3(1f,1f, transform.localScale.z + (Size*Time.deltaTime));

    }
}
