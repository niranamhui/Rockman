using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Text coinTxt;
    // Update is called once per frame
    void Update()
    {
        DisplayCoinText();
    }

    private void DisplayCoinText()
    {
        coinTxt.text = "coin :" + Gamemanager.Instance.coin.ToString();
    }
}
