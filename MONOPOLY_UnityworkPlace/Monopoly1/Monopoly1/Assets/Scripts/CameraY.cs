using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraY : MonoBehaviour
{
    //玩家对象
    public Transform player;
    public Transform y_Axis;

    //是否跟随玩家
    public bool followFlag;

    private void LateUpdate()
    {

        //跟随玩家
        if (followFlag && player != null)
        {
            y_Axis.position = Vector3.Lerp(y_Axis.position, player.position + Vector3.up, Time.deltaTime * 10f);
        }

    }
}