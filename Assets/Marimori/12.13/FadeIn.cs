using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] scene scene;
    [SerializeField] Image img; // 透明な黒い画像
    [SerializeField] float timer = 3f;
    float time;
    [SerializeField] float fadetime = 0.02f;

    //StartCoroutine("FadeIn"); // フェードインを開始

    public void ClickBotton()
    {
        StartCoroutine(Age());        
    }
    IEnumerator Age()
    {
        img.gameObject.SetActive(true); // 画像をアクティブにする

        Color c = img.color;
        c.a = 0f;
        img.color = c; // 画像の不透明度を1にする

        while (time < timer)
        {
            time += Time.deltaTime;
            float a = time / timer;
            c.a += fadetime;
            img.color = c; // 画像の不透明度を上げる
            yield return null;
            if (c.a >= 255f) // 不透明度が0以下のとき
            {
                break; // 繰り返し終了
            }
        }

        scene.LoadScenes();

    }

}
