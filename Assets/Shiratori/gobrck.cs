using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gobrck : MonoBehaviour
{
    public void NextScene()
    {
        // 読み込むシーンの名前を直接指定
        SceneManager.LoadScene("titoru");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OnClickEnter();
    }
    public void OnClickEnter()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("押された");
            SceneManager.LoadScene("taitoru");
        }
    }
}