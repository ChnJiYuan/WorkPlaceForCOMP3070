using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public PlayerMoney player; // 玩家对象
    public Button Buybutton; // 按钮对象
    public int[] isBought = new int[30];//判断是否被购买
    public GameObject buyList;
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

    void Start()
    {
        // 绑定按钮点击事件
        Buybutton.onClick.AddListener(OnButtonPress);
    }

    public void OnButtonPress()
    {
        Vector3 playerPosition = player.GetPlayerPosition();


        if (playerPosition.x < 0.32 && playerPosition.x > 0.28 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //台湾省
        {
            int cost = 99;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[0] == 0)
            {
                player.money -= cost;
                isBought[0] = 1;
                subTaiwan.GetComponent<Renderer>().material.color = Color.red;


            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < 0.22 && playerPosition.x > 0.18 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //苏丹
        {
            int cost = 60;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[1] == 0)
            {
                player.money -= cost;
                isBought[1] = 1;
                subSudan.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < 0.12 && playerPosition.x > 0.08 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //转盘1
        {
            int cost = -100;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;

            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < 0.007 && playerPosition.x > 0.0045 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //日本
        {
            int cost = 1;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[2] == 0)
            {
                player.money -= cost;
                isBought[2] = 1;
                subJapan.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.07 && playerPosition.x > -0.13 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //机会1
        {
            int cost = -200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.17 && playerPosition.x > -0.22 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //土耳其
        {
            int cost = 100;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[3] == 0)
            {
                player.money -= cost;
                isBought[3] = 1;
                subTurkey.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.26 && playerPosition.x > -0.30 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //希腊
        {
            int cost = 100;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[4] == 0)
            {
                player.money -= cost;
                isBought[4] = 1;
                subGreece.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.35 && playerPosition.x > -0.40 && playerPosition.z < -0.196 && playerPosition.z > -0.199) //保加利亚
        {
            int cost = 120;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[5] == 0)
            {
                player.money -= cost;
                isBought[5] = 1;
                subBulgaria.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.46 && playerPosition.x > -0.51 && playerPosition.z < -0.20 && playerPosition.z > -0.22) //监狱
        {
            int cost = 150;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < -0.10 && playerPosition.z > -0.123 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //波兰
        {
            int cost = 180;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[6] ==0)
            {
                player.money -= cost;
                isBought[6] = 1;
                subPoland.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < -0.009 && playerPosition.z > -0.026 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //乌克兰
        {
            int cost = 290;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[7] == 0)
            {
                player.money -= cost;
                isBought[7] = 1;
                subUkraine.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.098 && playerPosition.z > 0.07 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //梵蒂冈
        {
            int cost = 310;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[8] == 0)
            {
                player.money -= cost;
                isBought[8] = 1;
                subVatican.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.21 && playerPosition.z > 0.18 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //西班牙
        {
            int cost = 500;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[9] == 0)
            {
                player.money -= cost;
                isBought[9] = 1;
                subSpain.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.30 && playerPosition.z > 0.26 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //宝箱1
        {
            int cost = -200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.41 && playerPosition.z > 0.34 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //立陶宛
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[10] == 0)
            {
                player.money -= cost;
                isBought[10] = 1;
                subLithuania.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.51 && playerPosition.z > 0.46 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //拉脱维亚
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[11] == 0)
            {
                player.money -= cost;
                isBought[11] = 1;
                subLatvia.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.61 && playerPosition.z > 0.56 && playerPosition.x < -0.490 && playerPosition.x > -0.496) //塞内加尔
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[12] == 0)
            {
                player.money -= cost;
                isBought[12] = 1;
                subSenegal.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.72 && playerPosition.z > 0.68 && playerPosition.x < -0.49 && playerPosition.x > -0.51) //飞机场
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.38 && playerPosition.x > -0.42 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //德国
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[13] == 0)
            {
                player.money -= cost;
                isBought[13] = 1;
                subGermany.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.28 && playerPosition.x > -0.33 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //转盘2
        {
            int cost = 150;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.18 && playerPosition.x > -0.23 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //美国
        {
            int cost = 400;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[14] ==0)
            {
                player.money -= cost;
                isBought[14] = 1;
                subUnitedStates.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < -0.08 && playerPosition.x > -0.12 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //机会2
        {
            int cost = -9999;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < 0.006 && playerPosition.x > -0.01 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //芬兰
        {
            int cost = 240;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[15] == 0)
            {
                player.money -= cost;
                isBought[15] = 1;
                subFinland.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }

        if (playerPosition.x < 0.13 && playerPosition.x > 0.07 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //瑞典
        {
            int cost = 220;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[16] == 0)
            {
                player.money -= cost;
                isBought[16] = 1;
                subSweden.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < 0.22 && playerPosition.x > 0.17 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //挪威
        {
            int cost = 320;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[17] == 0)
            {
                player.money -= cost;
                isBought[17] = 1;
                subNorway.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < 0.31 && playerPosition.x > 0.27 && playerPosition.z < 0.713 && playerPosition.z > 0.681) //冰岛
        {
            int cost = 320;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[18] == 0)
            {
                player.money -= cost;
                isBought[18] = 1;
                subIceland.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.x < 0.42 && playerPosition.x > 0.39 && playerPosition.z < 0.715 && playerPosition.z > 0.69) //法官
        {
            int cost = 1000;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.62 && playerPosition.z > 0.58 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //墨西哥
        {
            int cost = 200;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[19] == 0)
            {
                player.money -= cost;
                isBought[19] = 1;
                subMexico.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }


        if (playerPosition.z < 0.52 && playerPosition.z > 0.48 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //智利
        {
            int cost = 180;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[20] == 0)
            {
                player.money -= cost;
                isBought[20] = 1;
                subChile.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }



        if (playerPosition.z < 0.42 && playerPosition.z > 0.38 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //迪拜
        {
            int cost = 360;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[21] == 0)
            {
                player.money -= cost;
                isBought[21] = 1;
                subDubai.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }



        if (playerPosition.z < 0.32 && playerPosition.z > 0.27 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //英国
        {
            int cost = 380;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[22] == 0)
            {
                player.money -= cost;
                isBought[22] = 1;
                subEngland.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }



        if (playerPosition.z < 0.22 && playerPosition.z > 0.18 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //宝箱2
        {
            int cost = -2000;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }



        if (playerPosition.z < 0.07 && playerPosition.z > 0.12 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //卡塔尔
        {
            int cost = 360;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[23] == 0)
            {
                player.money -= cost;
                isBought[23] = 1;
                subQatar.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }



        if (playerPosition.z < 0.01 && playerPosition.z > 0.003 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //夏威夷
        {
            int cost = 400;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost && isBought[24] == 0)
            {
                player.money -= cost;
                isBought[24] = 1;
                subHawaii.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }



        if (playerPosition.z < -0.07 && playerPosition.z > -0.13 && playerPosition.x < 0.413 && playerPosition.x > 0.388) //停车场
        {
            int cost = 100;

            // 判断玩家是否有足够的金钱
            if (player.money >= cost)
            {
                player.money -= cost;
            }
            else
            {
                Debug.Log("Not enough gold!");
            }
        }
        buyList.SetActive(false);
        Time.timeScale = (1); //时间开始





    }


}
