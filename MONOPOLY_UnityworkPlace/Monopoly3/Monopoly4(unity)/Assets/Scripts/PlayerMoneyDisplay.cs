using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoneyDisplay : MonoBehaviour
{
    public PlayerMoney playerMoneyDisplay;
    public Text moneyText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + playerMoneyDisplay.money.ToString();
    }
}