using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageNumber : MonoBehaviour
{
    [SerializeField] public int ThisStage = 1; //���ڂ̃X�e�[�W�Ȃ̂�
    public static int ThisSt = default;
    void Start()
    {
        //SerializeField��static�����Ɏg���Ȃ�������ł����������邽��
        ThisSt = ThisStage;
        Debug.Log("Thisgame" + ThisSt);
    }

    void Update()
    {
        
    }
}
