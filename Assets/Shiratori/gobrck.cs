using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gobrck : MonoBehaviour
{
    public void NextScene()
    {
        // �ǂݍ��ރV�[���̖��O�𒼐ڎw��
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
            Debug.Log("�����ꂽ");
            SceneManager.LoadScene("taitoru");
        }
    }
}