using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject enemy;

    private float time = 3;
    private Vector2 spawnPos;
    private float i;


    // Start is called before the first frame update
    void Start()
    {
        spawnPos = new Vector2 (1.5f, 8.5f);
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;
        if(i >= time)
        {
            SpawnTrash();
            i = 0;
        }
    }

    private void SpawnTrash()
    {
        Instantiate(enemy,spawnPos,Quaternion.identity);
    }
}
