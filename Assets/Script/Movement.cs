using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform[] wayPoints;
    Rigidbody2D rb;
    private Vector2 spawnpos;
    private float time;
    public Transform enemy;
    private int i = 0;
    private bool newWaypoint;
    public int speed;
    public int life;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnpos = new Vector2(1.5f, 9.5f);
        time = 4f;
        wayPoints = new Transform[9]; 

        for (int a = 0; a < 9; a++)
        {
            GameObject wayPointObject = GameObject.Find("WayPoint" + (a + 1));
            if (wayPointObject != null)
            {
                wayPoints[a] = wayPointObject.transform;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Invoke("SpawnEnenmy", time);
        Move();
    }

    public void EnemyGetDmg(int dmg)
    {
        life -= dmg;
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        Vector2 direction = new Vector2 (wayPoints[i].position.x - rb.position.x, wayPoints[i].position.y - rb.position.y ).normalized;

        rb.velocity = direction * speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WayPoint"))
        {

            Destroy(wayPoints[i]);
            i++;
            newWaypoint = true;
        }
    }
}

