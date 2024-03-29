using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot_Turret : MonoBehaviour
{

    public int dmg;
    public int speed;
    Rigidbody2D rb;
    private Transform enemy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindWithTag("Enemy").transform;
        BulletSpeed();
    }

    private void BulletSpeed()
    {
        Vector2 diretion = new Vector2(enemy.position.x - transform.position.x,enemy.position.y - transform.position.y);
        rb.velocity = diretion.normalized * speed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemy.GetComponent<Movement>().EnemyGetDmg(dmg);
            Destroy(gameObject);
        }
    }
}
