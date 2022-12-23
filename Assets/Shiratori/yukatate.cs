using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukatate : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 pos;
    public int muki = 1; //方向
    Vector3 syoki;

    private void Start()
    {
        syoki = transform.position; //初期座標
    }

    void Update()
    {
        pos = transform.position;

        transform.Translate(transform.up * Time.deltaTime * 5 * muki); //速度と方向を決める　

        if (pos.y > syoki.y + 6)//一番右に行った時の座標
        {
            muki = -1;
        }
        if (pos.y < syoki.y - 6) //一番左に行った時の座標
        {
            muki = 1;
        }
    }
}
