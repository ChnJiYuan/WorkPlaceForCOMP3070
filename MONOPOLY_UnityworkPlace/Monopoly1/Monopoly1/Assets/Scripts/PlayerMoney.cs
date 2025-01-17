using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMoney : MonoBehaviour
{
    public int money = 0;
    public GameObject victoryScreen;
    public bool canMove = true;

    // 触发器进入时调用
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bank"))
        {
            // 触发器标签为"Bank"，表示角色进入了银行区域
            BankTrigger bank = other.GetComponent<BankTrigger>();
            if (bank != null)
            {
                money += 10000;
                if (money >= 40000)
                { 
                  
                    victoryScreen.SetActive(true);

                    // 禁止角色移动
                    canMove = false;
                }
            }
        }
    }
    public Vector3 GetPlayerPosition()
    {
        return this.transform.position;
    }
}