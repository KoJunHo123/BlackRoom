using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndFadeInOut : MonoBehaviour
{
    Image Panelimage;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("GameClear", 0);
        Panelimage = GetComponent<Image>();
        if (PlayerPrefs.GetInt("GameClear") == 1)
            color = Color.black;
        if (PlayerPrefs.GetInt("GameClear") != 1)
            color = Color.red;
        Panelimage.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        color.a -= Time.deltaTime / 3f;
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
