using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager4 : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPosition; //�Ķ� ���� ������Ʈ ��ǥ, �������� ����
    [SerializeField] GameObject[] ObjectPrefabs; //��ǥ�� ���� ������Ʈ ������
    [SerializeField] Text RemainCount;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject FadeIn;
    [SerializeField] GameObject FadeOut_GameOver;
    [SerializeField] GameObject GameOverText;
    public int count;
    public bool GameOver;
    public bool GameClear;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            timer += Time.deltaTime;
            GameOverText.SetActive(true);
            if(timer>5.0f)
            Player.AddComponent<Rigidbody>();
            PlayerPrefs.SetInt("NowStage", 4);
            if (timer > 7.0f)
                SceneManager.LoadScene("GameOver");
        }

        if (GameClear)
            ClearGame();
        RemainCount.text = "Remain Monster: " + count;
    }

    public void SpawnObject()
    {
         int Index = SpawnPosition.Length;
         bool[] isSpawn = new bool[Index];
         for(int i = 0; i < Index; i++)
         {
             if (Random.Range(0, 100) % 2 == 1) //50�ۼ�Ʈ�� Ȯ���� ������� �Ķ��濡 ���� ��ü ����: ���� ��ü
             {
                 int a = Random.Range(0, ObjectPrefabs.Length);
                 int b = Random.Range(0, SpawnPosition.Length);
                 if (!isSpawn[b])
                 {
                    ObjectPrefabs[a].GetComponent<ObjectSetting>().SameOrDiff = true;
                    GameObject FlipObject = ObjectPrefabs[a];
                    Instantiate(ObjectPrefabs[a], SpawnPosition[b].position, SpawnPosition[b].rotation);
                    Quaternion t = FlipObject.transform.rotation;
                    FlipObject.transform.rotation = Quaternion.Euler(t.x, t.y + 180f, t.z);
                    Instantiate(FlipObject, new Vector3(SpawnPosition[b].transform.position.x, SpawnPosition[b].transform.position.y, -SpawnPosition[b].transform.position.z), Quaternion.Euler(t.x, t.y + 180f, t.z));
                    isSpawn[b] = true;
                 }
                 else i--;
             }
             else // �ٸ� ��ü ����
             {
                count++;
                 int a = Random.Range(0, ObjectPrefabs.Length);
                 int b = Random.Range(0, SpawnPosition.Length);
                int c = Random.Range(0, ObjectPrefabs.Length);
                while (a==c) c = Random.Range(0, ObjectPrefabs.Length);
                if (!isSpawn[b])
                {
                    ObjectPrefabs[a].GetComponent<ObjectSetting>().SameOrDiff = false;
                    GameObject FlipObject = ObjectPrefabs[a];
                    Instantiate(ObjectPrefabs[a], SpawnPosition[b].position, SpawnPosition[b].rotation);
                    Quaternion t = FlipObject.transform.rotation;
                    FlipObject.transform.rotation = Quaternion.Euler(t.x, t.y + 180f, t.z);
                    Instantiate(ObjectPrefabs[c], new Vector3(SpawnPosition[b].transform.position.x, SpawnPosition[b].transform.position.y, -SpawnPosition[b].transform.position.z), Quaternion.Euler(t.x, t.y + 180f, t.z));

                    isSpawn[b] = true;
                }
                else { i--; count--; }
             }

            if (count == 0 && i == Index-1)
                i--;
         }    

    }

    public void CheckGameState()
    {
        if (count == 0)
            GameClear = true;
    }
    public void ClearGame()
    {
        //���� Ŭ����� ����
        SceneManager.LoadScene(5);
        
    }

    
}
