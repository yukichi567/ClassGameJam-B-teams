using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukayoko : MonoBehaviour
{
    // Start is called before the first frame update
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
}
