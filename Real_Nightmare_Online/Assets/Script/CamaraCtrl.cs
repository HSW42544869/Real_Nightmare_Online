using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCtrl : MonoBehaviour
{
    [Header("追蹤物件")]
    public Transform target;
    [Header("移動速度")]
    public float speed = 2;
    private void Update()
    {
        Track();
    }

    /// <summary>
    /// 物件追蹤
    /// </summary>
    private void Track()
    {
        Vector2 posA = target.position;     // 目標座標
        Vector2 posB = transform.position;  // 攝影機座標

        posB = Vector2.Lerp(posB, posA,Time.deltaTime * speed); 
        transform.position = posB;                                      
    }

}
