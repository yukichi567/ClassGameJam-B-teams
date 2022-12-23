using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Image img; // �����ȍ����摜
    [SerializeField] float timer = 2f;
    float time;
    [SerializeField] float fadetime = 0.02f;

    private void Start()
    {
        StartCoroutine(Age());
    }    
    
    IEnumerator Age()
    {
        img.gameObject.SetActive(true); // �摜���A�N�e�B�u�ɂ���

        Color c = img.color;
        c.a = 1f;
        img.color = c; // �摜�̕s�����x��1�ɂ���

        while (time < timer)
        {
            time += Time.deltaTime;
            float a = time / timer;
            c.a -= fadetime;
            img.color = c; // �摜�̕s�����x���グ��
            yield return null;
            if (c.a <= 0f) // �s�����x��0�ȉ��̂Ƃ�
            {
                c.a = 0f;
                img.color = c; // �s�����x��0
                break; // �J��Ԃ��I��
            }
        }

        img.gameObject.SetActive(false); // �摜���A�N�e�B�u�ɂ���

    }

}
