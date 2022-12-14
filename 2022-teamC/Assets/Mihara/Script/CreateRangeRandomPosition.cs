using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject createPrefab;
    [SerializeField]
    private Transform rangeA;
    [SerializeField]
    private Transform rangeB;

    //時間間隔の最小値
    public float minTime = 2f;
    //時間間隔の最大値
    public float maxTime = 5f;

    private float interval;

    private float time = 0f;
    void Start()
    {
        //時間間隔を決定する
        interval = GetRandomTime();
    }


    void Update()
    {

        time = time + Time.deltaTime;

        if (time > interval)
        {
            float x = -10f;
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            float z = 0f;

            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

            time = 0f;
            //次に発生する時間間隔を決定する
            interval = GetRandomTime();
        }
        //ランダムな時間を生成する関数

    }
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }


}