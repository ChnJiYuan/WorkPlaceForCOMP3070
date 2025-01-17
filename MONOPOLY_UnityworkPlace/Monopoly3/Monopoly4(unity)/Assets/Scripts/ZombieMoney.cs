using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZombieMoney : MonoBehaviour
{
    public int Zmoney = 0;
    public GameObject lossScreen;
  public bool ZombiecanMove = true;

    // 触发器进入时调用
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Prison"))
        {
            // 触发器标签为"Prison"，表示zombie进入了监狱区域
            PrisonTrigger prison = other.GetComponent<PrisonTrigger>();
            if (prison != null)
            {
                Zmoney += 500;
                if (Zmoney >= 40000)
                { 
                  
                    lossScreen.SetActive(true);

                    // 禁止zombie移动
                    ZombiecanMove = false;
                }
            }
        }
    }
    public Vector3 GetZombiePosition()
    {
        return this.transform.position;
    }
}