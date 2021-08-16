using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutScreen : MonoBehaviour
{
    Color color;
    float delta;
    // Start is called before the first frame update
    void Start()
    {
        color = Color.red;
        color.a = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        color.a += Time.deltaTime / 2f;
        if (delta < 5f)
        {
            gameObject.GetComponent<Image>().color = color;
        }
    }
}
