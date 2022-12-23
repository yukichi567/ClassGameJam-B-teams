using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RCTime : MonoBehaviour
{ 
    public static�@float RecordTimer = 0;
    public int Second = 0;
    public int minutes = 0;
    [SerializeField] public Text TimeText;
    public bool TimeStop = false; //�N���A��������G�ɓ������������\��

    void Start()
    {
        RecordTimer = 0;
        TimeStop = false;
    }

    void Update()
    {
        //�J�E���g�_�E����
        if (TimeStop == false)
        {
            RecordTimer += Time.deltaTime;
        }
        minutes = (int)RecordTimer / 60;
        Second = (int)RecordTimer % 60;
        TimeText.text = minutes + ":" + Second;



        //Debug.Log("RCT" + RecordTimer);
        //Debug.Log("SEC" + Second);
        //Debug.Log("MIN" + minutes);
        if (Input.GetKey(KeyCode.N))///test�p�̃^�C���X�g�b�v
        {
            TimeStop = true;
        }
        if (Input.GetKey(KeyCode.M))///test�p�̃V�[���ړ�
        {
            SceneManager.LoadScene("onlinetestResult");
        }
    }
}
