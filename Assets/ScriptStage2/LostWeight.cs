using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LostWeight : MonoBehaviour
{
    StageManager2 Manager;
    [SerializeField] Text LostText;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Manager = FindObjectOfType<StageManager2>();
        if (Manager.GameOver)
        {
            Debug.Log("1");
            LostText.gameObject.SetActive(true);
            timer += Time.deltaTime;
            if (timer > 3.0f)
                Destroy(LostText);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Manager = FindObjectOfType<StageManager2>();
        if (other.gameObject.layer == 8)
        {
            Destroy(other);
            Manager.GameOver = true;
        }
    }
}
