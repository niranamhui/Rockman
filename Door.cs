using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Door : MonoBehaviour
{
    public Text TxteEnd;
    public GameObject END;

    private void Start()
    {
        END.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

                if (Gamemanager.Instance.coin >= 100)
                {
                    SceneManager.LoadScene("ENG");
                }
                
                else if (Gamemanager.Instance.coin < 100)
                 {
                    END.SetActive(true);
                    TxteEnd.text = "END";
                }
        }

    }
}
