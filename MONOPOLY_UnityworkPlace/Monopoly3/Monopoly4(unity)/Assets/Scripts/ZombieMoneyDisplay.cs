using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieMoneyDisplay : MonoBehaviour
{
    public ZombieMoney zombieMoneyDisplay;
    public Text ZmoneyText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ZmoneyText.text = "$" + zombieMoneyDisplay.Zmoney.ToString();
    }
}