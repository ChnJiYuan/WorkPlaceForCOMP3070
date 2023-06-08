using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraY : MonoBehaviour
{
    //控制左右旋转
    public Transform y_Axis;
    //控制上下旋转
    public Transform x_Axis;
    //控制左右倾斜
    public Transform z_Axis;
    //控制远近距离
    public Transform zoom_Axis;

    //玩家对象
    public Transform player;


    //旋转速度
    public float roSpeed = 5;
    //缩放速度
    public float scSpeed = 5;
    //限定角度
    public float limitAngle = 180;

    //鼠标左右滑动数值
    private float hor, ver, scrollView;
    float x = 0, sc = 10;

    //是否跟随玩家
    public bool followFlag;
    //是否控制玩家旋转
    public bool turnFlag;

    private void LateUpdate()
    {
        //获取输入
        hor = Input.GetAxis("Mouse X");
        ver = Input.GetAxis("Mouse Y");
        //鼠标滚轮数值
        scrollView = Input.GetAxis ("Mouse ScrollWheel");

        
        //缩放远近
        if (scrollView != 0) {
            sc -= scrollView * scSpeed;
            sc = Mathf.Clamp(sc, 3, 10);
            zoom_Axis.transform.localPosition = new Vector3(0, 0, -sc);
        }

        //跟随玩家
        if (followFlag && player != null) {
            y_Axis.position = Vector3.Lerp(y_Axis.position, player.position + Vector3.up, Time.deltaTime * 10f);
        }


    }


}