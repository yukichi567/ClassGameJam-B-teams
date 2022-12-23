using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] scene scene;
    [SerializeField] Image img; // �����ȍ����摜
    [SerializeField] float timer = 3f;
    float time;
    [SerializeField] float fadetime = 0.02f;

    //StartCoroutine("FadeIn"); // �t�F�[�h�C�����J�n

    public void ClickBotton()
    {
        StartCoroutine(Age());        
    }
    IEnumerator Age()
    {
        img.gameObject.SetActive(true); // �摜���A�N�e�B�u�ɂ���

        Color c = img.color;
        c.a = 0f;
        img.color = c; // �摜�̕s�����x��1�ɂ���

        while (time < timer)
        {
            time += Time.deltaTime;
            float a = time / timer;
            c.a += fadetime;
            img.color = c; // �摜�̕s�����x���グ��
            yield return null;
            if (c.a >= 255f) // �s�����x��0�ȉ��̂Ƃ�
            {
                break; // �J��Ԃ��I��
            }
        }

        scene.LoadScenes();

    }

}
