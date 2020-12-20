using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed;
    public float health;
    public CharacterController controller;
    float horiMove;
    float vertMove;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        horiMove = Input.GetAxis("Horizontal");
        vertMove = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horiMove + transform.forward * vertMove;

        controller.Move(move * speed);
    }

    void GameOver()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

   void OnCollisionEnter (Collision collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            health -= 1;
        }
    }
}
