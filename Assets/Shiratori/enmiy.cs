using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmiy: MonoBehaviour
{
    private Vector2 pos;
    public int muki = 1; //����
    Vector3 syoki;

    private void Start()
    {
        syoki = transform.position; //�������W
    }

    void Update()
    {
        pos = transform.position;
        
        transform.Translate(transform.right * Time.deltaTime * 5 * muki); //���x�ƕ��������߂�@

        if (pos.x > syoki.x + 4)//��ԉE�ɍs�������̍��W
        {
            muki = -1;
        }
        if (pos.x < syoki.x - 4) //��ԍ��ɍs�������̍��W
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