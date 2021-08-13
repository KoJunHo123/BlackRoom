using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFadeIn : MonoBehaviour
{
    Image Panelimage;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        Panelimage = GetComponent<Image>();
        color = Panelimage.color;
    }

    // Update is called once per frame
    void Update()
    {
        color.a -= Time.deltaTime / 2f;
        Panelimage.color = color;
        if (Panelimage.color.a < 0.01f)
        {
            color.a = 0f;
            Panelimage.color = color;
            gameObject.GetComponent<ScreenFadeIn>().enabled = false;
            gameObject.SetActive(false);
        }

    }
}
