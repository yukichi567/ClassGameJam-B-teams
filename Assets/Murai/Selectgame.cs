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
    [SerializeField] int MaxSt = 4; //���݂̑S�X�e�[�W�������Ăق����ł�
    
    void Start()
    {
        
    }

    void Update()
    {
        StageText.text = "" + SelectSt;
        //A��D�ŃX�e�[�W�I���A�X�y�[�X�Ō���
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
        //�Z���N�g�Ńx�X�g�^�C�����������炢����˂�
        if(SelectSt == 1)
        {
            Best = PlayerPrefs.GetFloat("Time1", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if(Best != 0)
            {
                BestText.text = "�x�X�g�^�C��" + minutes + ":" + Second ;
            }
            if (Best == 0)
            {
                BestText.text = "���N���A�ł�";
            }

        }
        if (SelectSt == 2)
        {
            Best = PlayerPrefs.GetFloat("Time2", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if (Best != 0)
            {
                BestText.text = "�x�X�g�^�C��" + minutes + ":" + Second;
            }
            if (Best == 0)
            {
                BestText.text = "���N���A�ł�";
            }

        }
        if (SelectSt == 3)
        {
            Best = PlayerPrefs.GetFloat("Time3", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if (Best != 0)
            {
                BestText.text = "�x�X�g�^�C��" + minutes + ":" + Second;
            }
            if (Best == 0)
            {
                BestText.text = "���N���A�ł�";
            }

        }
        if (SelectSt == 4)
        {
            Best = PlayerPrefs.GetFloat("Time4", 0);
            minutes = (int)Best / 60;
            Second = (int)Best % 60;
            if (Best != 0)
            {
                BestText.text = "�x�X�g�^�C��" + minutes + ":" + Second;
            }
            if (Best == 0)
            {
                BestText.text = "���N���A�ł�";
            }

        }
        //�V�[���𒼐ڑł����݂܂��傤�i���̂�����������Ȃ��j
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
        //�x�X�g���R�[�h�̍폜
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
        Debug.Log(SelectSt);
    }
}
