using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyList : MonoBehaviour
{
    public GameObject buyList; //�����б�

    [SerializeField] private bool buyKeys = true; //���빺���б�

    // 
    void Start()
    {

    }

    // 
    void Update()
    {
        if (buyKeys)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                buyList.SetActive(true);
                buyKeys = false;
                Time.timeScale = 0; //ʱ����ͣ
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            buyList.SetActive(false);
            buyKeys = true;
            Time.timeScale = 1; //ʱ�俪ʼ
        }

    }
}