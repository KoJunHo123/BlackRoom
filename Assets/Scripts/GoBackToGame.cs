using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToGame : MonoBehaviour
{
    [SerializeField] GameObject Door;
    [SerializeField] GameObject FadeOut;
    public float delta;
    public bool TryAgain;
    void Start()
    {

    }

    void Update()
    {
        if (TryAgain)
        {
            delta += Time.deltaTime;
             transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * 3);
              Door.transform.localScale = new Vector3(Door.transform.localScale.x + Time.deltaTime, Door.transform.localScale.y + Time.deltaTime, Door.transform.localScale.z);
            FadeOut.SetActive(true);

            if (delta > 3f)
                SceneManager.LoadScene(PlayerPrefs.GetInt("NowStage"));
        }
        
    }

    public void MoveChange()
    {
        TryAgain = true;
    }

}
