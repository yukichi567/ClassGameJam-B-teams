using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmiy: MonoBehaviour
{
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
        
        transform.Translate(transform.right * Time.deltaTime * 5 * muki); //速度と方向を決める　

        if (pos.x > syoki.x + 4)//一番右に行った時の座標
        {
            muki = -1;
        }
        if (pos.x < syoki.x - 4) //一番左に行った時の座標
        {
            muki = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }

    void End()
    {
       // gameObject.SetActive
    }

}