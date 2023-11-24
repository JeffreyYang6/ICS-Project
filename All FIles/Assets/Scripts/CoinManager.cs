using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int CoinCount;
    public TextMeshProUGUI coinText;
   
    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coin Count: " + CoinCount.ToString();
    }
}
