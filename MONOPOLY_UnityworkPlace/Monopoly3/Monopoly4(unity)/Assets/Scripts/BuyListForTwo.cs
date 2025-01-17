using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyListForTwo : MonoBehaviour
{
    public GameObject buyListForTwo; //购买列表

    [SerializeField] private bool buyKeysForTwo = true; //引入购买列表
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buyKeysForTwo)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                buyListForTwo.SetActive(true);
                buyKeysForTwo = false;
                Time.timeScale = (0); //时间暂停
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            buyListForTwo.SetActive(false);
            buyKeysForTwo = true;
            Time.timeScale = (1); //时间开始
        }
    }
}
