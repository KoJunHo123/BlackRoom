using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    GetAnswer Clear;
    // Start is called before the first frame update
    void Start()
    {
        //�������� Ŭ����� ���� �ۼ��� ��
    }

    // Update is called once per frame
    void Update()
    {
        Clear = FindObjectOfType<GetAnswer>();
        if (Clear.StageClear == true)
            SceneManager.LoadScene(4);
    }
}
