using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float currentHealth;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDirection = target.transform.position - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);

        transform.position += transform.forward * speed * Time.deltaTime;
        Difficulty();
       
    }

    void Difficulty()
    {
        
        if (currentHealth == health / 2)
        {
            speed = 20 ;
        }

        else if (currentHealth == health / 4)
        {
            speed = 30;
        }

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            currentHealth -= 1;
        }

       
    }
}
