using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButtonForTwo : MonoBehaviour
{
    public ZombieMoney player;// 玩家对象
    public Button Salebutton; // 按钮对象
    public BuyButton getIfBought;//获取购买信息
    public GameObject buyListForTwo;
    public GameObject subTaiwan;
    public GameObject subSudan;
    public GameObject subJapan;
    public GameObject subTurkey;
    public GameObject subGreece;
    public GameObject subBulgaria;
    public GameObject subPoland;
    public GameObject subUkraine;
    public GameObject subVatican;
    public GameObject subLithuania;
    public GameObject subLatvia;
    public GameObject subGermany;
    public GameObject subUnitedStates;
    public GameObject subFinland;
    public GameObject subSweden;
    public GameObject subNorway;
    public GameObject subIceland;
    public GameObject subMexico;
    public GameObject subChile;
    public GameObject subDubai;
    public GameObject subEngland;
    public GameObject subQatar;
    public GameObject subHawaii;
    public GameObject subSpain;
    public GameObject subSenegal;
    // Start is called before the first frame update
    void Start()
    {
        // 绑定按钮点击事件
        Salebutton.onClick.AddListener(OnButtonPress);
    }
    public void OnButtonPress()
    {

        Vector3 playerPosition = player.GetZombiePosition();


        if (playerPosition.x < 0.32 && playerPosition.x > 0.28 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //台湾省
        {
            int cost = 99;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[0] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[0] = 0;
                subTaiwan.GetComponent<Renderer>().material.color = Color.white;


            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < 0.22 && playerPosition.x > 0.18 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //苏丹
        {
            int cost = 60;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[1] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[1] = 0;
                subSudan.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < 0.007 && playerPosition.x > 0.0045 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //日本
        {
            int cost = 1;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[2] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[2] = 0;
                subJapan.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < -0.17 && playerPosition.x > -0.22 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //土耳其
        {
            int cost = 100;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[3] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[3] = 0;
                subTurkey.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");

            }
        }
        if (playerPosition.x < -0.26 && playerPosition.x > -0.30 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //希腊
        {
            int cost = 100;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[4] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[4] = 0;
                subGreece.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.x < -0.35 && playerPosition.x > -0.40 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //保加利亚
        {
            int cost = 120;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[5] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[5] = 0;
                subBulgaria.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.z < -0.10 && playerPosition.z > -0.123 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //波兰
        {
            int cost = 180;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[6] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[6] = 0;
                subPoland.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.z < -0.009 && playerPosition.z > -0.026 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //乌克兰
        {
            int cost = 290;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[7] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[7] = 0;
                subUkraine.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.z < 0.098 && playerPosition.z > 0.07 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //梵蒂冈
        {
            int cost = 310;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[8] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[8] = 0;
                subVatican.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.z < 0.21 && playerPosition.z > 0.18 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //西班牙
        {
            int cost = 500;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[9] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[9] = 0;
                subSpain.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.z < 0.21 && playerPosition.z > 0.18 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //西班牙
        {
            int cost = 500;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[9] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[9] = 0;
                subSpain.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }

        else if (playerPosition.z < 0.41 && playerPosition.z > 0.34 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //立陶宛
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[10] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[10] = 0;
                subLithuania.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.z < 0.51 && playerPosition.z > 0.46 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //拉脱维亚
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[11] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[11] = 0;
                subLatvia.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.z < 0.61 && playerPosition.z > 0.56 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //塞内加尔
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[12] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[12] = 0;
                subSenegal.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        else if (playerPosition.x < -0.38 && playerPosition.x > -0.42 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //德国
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[13] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[13] = 0;
                subGermany.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < -0.18 && playerPosition.x > -0.23 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //美国
        {
            int cost = 400;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[14] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[14] = 0;
                subUnitedStates.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < 0.006 && playerPosition.x > -0.01 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //芬兰
        {
            int cost = 240;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[15] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[15] = 0;
                subFinland.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < 0.13 && playerPosition.x > 0.07 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //瑞典
        {
            int cost = 220;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[16] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[16] = 0;
                subSweden.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < 0.22 && playerPosition.x > 0.17 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //挪威
        {
            int cost = 320;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[17] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[17] = 0;
                subNorway.GetComponent<Renderer>().material.color = Color.white;
            }
            else

            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.x < 0.31 && playerPosition.x > 0.27 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //冰岛
        {
            int cost = 320;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[18] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[18] = 0;
                subIceland.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.z < 0.62 && playerPosition.z > 0.58 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //墨西哥
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[19] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[19] = 0;
                subMexico.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.z < 0.52 && playerPosition.z > 0.48 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //智利
        {
            int cost = 180;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[20] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[20] = 0;
                subChile.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.z < 0.42 && playerPosition.z > 0.38 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //迪拜
        {
            int cost = 360;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[21] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[21] = 0;
                subDubai.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
        if (playerPosition.z < 0.32 && playerPosition.z > 0.27 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //英国
        {
            int cost = 380;

            // 判断玩家是否有足够的金钱
            if (getIfBought.isBought[22] == 2)
            {
                player.Zmoney += cost;
                getIfBought.isBought[22] = 0;
                subEngland.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("you did not buy this land");
            }
        }
            if (playerPosition.z < 0.07 && playerPosition.z > 0.12 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //卡塔尔
            {
                int cost = 360;

                // 判断玩家是否有足够的金钱
                if (getIfBought.isBought[23] == 2)
                {
                    player.Zmoney += cost;
                    getIfBought.isBought[23] = 0;
                    subQatar.GetComponent<Renderer>().material.color = Color.white;
                }
                else
                {
                    Debug.Log("you did not buy this land");
                }
            }
            if (playerPosition.z < 0.01 && playerPosition.z > 0.003 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //夏威夷
            {
                int cost = 400;

                // 判断玩家是否有足够的金钱
                if (getIfBought.isBought[24] == 2)
                {
                    player.Zmoney += cost;
                    getIfBought.isBought[24] = 0;
                    subHawaii.GetComponent<Renderer>().material.color = Color.white;
                }
                else
                {
                    Debug.Log("you did not buy this land");
                }
            }
            buyListForTwo.SetActive(false);
            Time.timeScale = (1); //时间开始

        }

    }

