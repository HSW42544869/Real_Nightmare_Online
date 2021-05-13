using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// 角色狀態
    /// </summary>
    [Header("血量")]
    public int health = 5;
    [Header("體力")]
    public int tired = 5;
    [Header("移動速度")]
    public float movespeed = 0.01f;

    /// <summary>
    /// 槍枝
    /// </summary>
    [Header("槍枝取得")]
    public bool getgun = false;
    [Header("子彈")]
    public int bullet = 10;
    [Header("彈夾")]
    public int clip = 0;

    [Header("移動精靈")]
    public Transform target;

    private float reho = 0 ;
    private Joystick Movejoy;
    private Joystick Spinjoy;

    protected void Awake()
    {
        target = GameObject.Find("Mover").transform;
        Movejoy = GameObject.Find("MoveJoy").GetComponent<Joystick>();
        Spinjoy = GameObject.Find("SpinJoy").GetComponent<Joystick>();
    }
    private void Update()
    {
        MOVE();
        ROTATE();
    }

    /// <summary>
    /// 角色移動
    /// </summary>
    private void MOVE()
    {
        Vector3 dir = Movejoy.Direction * movespeed * 0.5f; // 取得搖桿向量
        transform.position = transform.position + dir;  // 移動角色
    }
    /// <summary>
    /// 角色旋轉
    /// </summary>
    private void ROTATE()
    {
        
        float ho = Spinjoy.Horizontal;  // 取得水平位移
        if (reho != ho)                 // 旋轉角色並記錄停止
        {
            transform.Rotate(0, 0, ho * -1);
            reho = ho;
        }
    }

}
