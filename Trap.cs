using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject Guon;
    Rigidbody2D rb2dgum;
    public float speed = 6f;

    void Start()
    {
        rb2dgum = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //rb2dgum.velocity = Vector2.down * 2;
            transform.Translate(0, speed , 0);
        }
    }
}
