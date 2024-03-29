using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret1 : MonoBehaviour
{

    public GameObject bullet;
    public float time;
    private float i;
    private Transform enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;
        enemy = GameObject.FindWithTag("Enemy").transform;
        TurretShoot();
    }

    private void TurretShoot()
    {
        float dis =  Vector2.Distance(transform.position,enemy.position );

        if (i >= time && dis < 10f) 
        {
            Instantiate(bullet, transform.position,Quaternion.identity);
            i = 0;
            Debug.Log("Shoot");
        }
    }
}
