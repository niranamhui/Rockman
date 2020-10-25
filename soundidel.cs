using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundidel : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Soundmanager.Instance.audioSource.PlayOneShot(Soundmanager.Instance.Soundcoin);
        }
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamemanager.Instance.coin += 1;
            Soundmanager.Instance.audioSource.PlayOneShot(Soundmanager.Instance.Soundcoin);
            Destroy(gameObject, 0.1f);
        }

    }

}
