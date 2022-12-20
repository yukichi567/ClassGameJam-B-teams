using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selectgame : MonoBehaviour
{
    int SelectSt = 1;
    public float Best = default;
    public int Second = 0;
    public int minutes = 0;
    [SerializeField] public Text StageText;
    [SerializeField] public Text BestText;
    [SerializeField] int MaxSt = 5; //現在の全ステージ数を入れてほしいです
    
    void Start()
    {
        
    }

    void Update()
    {
        StageText.text = "" + SelectSt;
        //AとDでステージ選択、スペースで決定
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (SelectSt == 1)
            {
                SelectSt = MaxSt;
            }
            else
            {
                SelectSt--;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (SelectSt == MaxSt)
            {
                SelectSt = 1;
            }
            else
            {
                SelectSt++;
            }
        }
        //セレクトでベストタイム分かったらいいよねと
        if(SelectSt == 1)
        {
            Best = PlayerPrefs.GetFloat("Time1", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if(Best != 0)
            {
                BestText.text = "ベストタイム" + minutes + ":" + Second ;
            }
            if (Best == 0)
            {
                BestText.text = "未クリアです";
            }

        }
        if (SelectSt == 2)
        {
            Best = PlayerPrefs.GetFloat("Time2", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if (Best != 0)
            {
                BestText.text = "ベストタイム" + minutes + ":" + Second;
            }
            if (Best == 0)
            {
                BestText.text = "未クリアです";
            }

        }
        if (SelectSt == 3)
        {
            Best = PlayerPrefs.GetFloat("Time3", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if (Best != 0)
            {
                BestText.text = "ベストタイム" + minutes + ":" + Second;
            }
            if (Best == 0)
            {
                BestText.text = "未クリアです";
            }

        }
        if (SelectSt == 4)
        {
            Best = PlayerPrefs.GetFloat("Time4", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if (Best != 0)
            {
                BestText.text = "ベストタイム" + minutes + ":" + Second;
            }
            if (Best == 0)
            {
                BestText.text = "未クリアです";
            }

        }
        //シーンを直接打ち込みましょう（他のやり方が分からない）
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SelectSt == 1)
            {
                SceneManager.LoadScene("onlinetestgame");
            }
            if (SelectSt == 2)
            {
                SceneManager.LoadScene("onlinetestgame2");
            }
            if (SelectSt == 3)
            {
                SceneManager.LoadScene("");
            }
            if (SelectSt == 4)
            {
                SceneManager.LoadScene("");
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
        Debug.Log(SelectSt);
    }
}
