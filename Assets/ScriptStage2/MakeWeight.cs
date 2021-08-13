using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWeight : MonoBehaviour
{
    [SerializeField] GameObject weightPrefab;
    [SerializeField] GameObject weightAnswer;
    [SerializeField] Transform[] weightPosition = new Transform[9];
    public int[] Index = new int[9];
    // Start is called before the first frame update
    void Start()
    {
        SetStage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStage()
    {
        for (int i = 0; i < weightPosition.Length; i++)
        {
            Index[i] = Random.Range(0, 9);
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                    if (Index[j] == Index[i])
                        i--;
            }
        }
        for (int i = 0; i < weightPosition.Length - 1; i++)
            Instantiate(weightPrefab, weightPosition[Index[i]]);
        Instantiate(weightAnswer, weightPosition[Index[weightPosition.Length - 1]]);
    }
}
