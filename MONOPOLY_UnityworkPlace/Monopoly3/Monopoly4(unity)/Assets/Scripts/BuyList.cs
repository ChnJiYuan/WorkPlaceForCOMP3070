using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyList : MonoBehaviour
{
    public GameObject buyList; //购买列表

    [SerializeField] private bool buyKeys = true; //引入购买列表

    // 
    void Start()
    {

    }

    // 
    void Update()
    {
        if (buyKeys)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                buyList.SetActive(true);
                buyKeys = false;
                Time.timeScale = (0); //时间暂停
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            buyList.SetActive(false);
            buyKeys = true;
            Time.timeScale = (1); //时间开始
        }

    }
}
