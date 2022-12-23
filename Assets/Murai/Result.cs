using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public float ClearRecord = default;
    public int ClearSecond = 0;
    public int Clearminutes = 0;
    public float BestRecord = default;
    public int BestSecond = 0;
    public int Bestminutes = 0;
    public int Select = 1;
    [SerializeField] public Text ClearTimeText;
    [SerializeField] public Text BestTimeText;
    [SerializeField] public Text NextText;
    [SerializeField] public Text OnemoreText;
    [SerializeField] public Text SelectText;
    [SerializeField] public Text TitleText;

    void Start()
    {
        Debug.Log(StageNumber.ThisSt);
        //今回のスコアの取得
        ClearRecord = RCTime.RecordTimer;
        //ベストスコアの取得
        if(StageNumber.ThisSt == 1)
        {
            BestRecord = PlayerPrefs.GetFloat("Time1", 0);
        }
        if (StageNumber.ThisSt == 2)
        {
            BestRecord = PlayerPrefs.GetFloat("Time2", 0);
        }
        if (StageNumber.ThisSt == 3)
        {
            BestRecord = PlayerPrefs.GetFloat("Time3", 0);
        }
        if (StageNumber.ThisSt == 4)
        {
            BestRecord = PlayerPrefs.GetFloat("Time4", 0);
        }
        Clearminutes = (int)ClearRecord / 60;
        ClearSecond = (int)ClearRecord % 60;
        Bestminutes = (int)BestRecord / 60;
        BestSecond = (int)BestRecord % 60;
        ClearTimeText.text = Clearminutes + ":" + ClearSecond;
        BestTimeText.text = Bestminutes + ":" + BestSecond;


        //ベストスコアの保存
        if (StageNumber.ThisSt == 1)
        {
            if(BestRecord > ClearRecord || BestRecord == 0 )
            {
                PlayerPrefs.SetFloat("Time1", ClearRecord);
                PlayerPrefs.Save();
            }
        }
        if (StageNumber.ThisSt == 2)
        {
            if (BestRecord > ClearRecord || BestRecord == 0)
            {
                PlayerPrefs.SetFloat("Time2", ClearRecord);
                PlayerPrefs.Save();
            }
        }
        if (StageNumber.ThisSt == 3)
        {
            if (BestRecord > ClearRecord || BestRecord == 0)
            {
                PlayerPrefs.SetFloat("Time3", ClearRecord);
                PlayerPrefs.Save();
            }
        }
        if (StageNumber.ThisSt == 4)
        {
            if (BestRecord > ClearRecord || BestRecord == 0)
            {
                PlayerPrefs.SetFloat("Time4", ClearRecord);
                PlayerPrefs.Save();
            }
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Select == 1)
            {
                Select = 4;
            }
            else
            {
                Select--;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Select == 4)
            {
                Select = 1;
            }
            else
            {
                Select++;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))//シーン名は直接打ち込みましょう（）
        {
            //1は次ステージへへ
            if(Select == 1)
            {
                if(StageNumber.ThisSt == 1)
                {
                    //SceneManager.LoadScene("");
                    SceneManager.LoadScene("onlinetestgame2");
                }
                if (StageNumber.ThisSt == 2)
                {
                    //SceneManager.LoadScene("");
                }
                if (StageNumber.ThisSt == 3)
                {
                    //SceneManager.LoadScene("");
                }
            }
            //２はコンテニュー
            if (Select == 2)
            {
                if (StageNumber.ThisSt == 1)
                {
                    //SceneManager.LoadScene("");
                    SceneManager.LoadScene("onlinetestgame");
                }
                if (StageNumber.ThisSt == 2)
                {
                    //SceneManager.LoadScene("");
                    SceneManager.LoadScene("onlinetestgame2");
                }
                if (StageNumber.ThisSt == 3)
                {
                    //SceneManager.LoadScene("");
                }
                if (StageNumber.ThisSt == 4)
                {
                    //SceneManager.LoadScene("");
                }
            }
            //３はセレクトへ
            if (Select == 3)
            {
                // SceneManager.LoadScene("");
                SceneManager.LoadScene("onlinetestSelect");
            }
            //４はタイトルへ
            if (Select == 4)
            {
                //SceneManager.LoadScene("");
            }

        }
    }
}
