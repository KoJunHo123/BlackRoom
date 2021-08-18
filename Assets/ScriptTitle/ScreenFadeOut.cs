using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenFadeOut : MonoBehaviour
{
    [SerializeField] GameObject Path;
    float delta = 0;
    Image Panelimage;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        Panelimage = GetComponent<Image>();

        if (Path.activeSelf == true)
        {
            if (SceneManager.GetActiveScene().name == "GameEnd")
                color = Color.white;
            else if(SceneManager.GetActiveScene().name == "Title")
                color = Color.black;
            color.a = 0.0f;
            Panelimage.color = color;
        }
        else
        {
            color = Color.red;
            color.a = 0.0f;
            Panelimage.color = color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        color.a += Time.deltaTime / 3f;
        if (delta < 5f)
        {
            Panelimage.color = color;
        }
    }
}
