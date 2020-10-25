using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : Singleton<Gamemanager>
{
    public int coin;
    public bool magicKey;
    public int level;

    public Vector3 spawnValues;
    public Text gameOverTxet;
    public Text RestartTxet;
    public GameObject deathEffect;
    private int score;
    private bool gameOver;
    private bool Restart;

    private void Awake()
    {
        coin = 0;
        magicKey = false;
        level = 1;
    }

    private void Start()
    {
        gameOver = false;
        Restart = false;

        gameOverTxet.text = "";
        RestartTxet.text = "";

        InvokeRepeating("AddEmy", 2f, 5f);
    }

    void AddEmy()
    {
        if (gameOver == false)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Instantiate(deathEffect, spawnPosition, Quaternion.identity);
        }
        else
        {
            CancelInvoke("AddEmy");
        }
    }
    public void GameOver()
    {
        gameOverTxet.text = "Game Over";
        gameOver = true;
    }
    void Update()
    {
        if (gameOver)
        {
            Restart = true;
            RestartTxet.text = "Press 'R' for Resart";

        }

        if (Restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
    
}
