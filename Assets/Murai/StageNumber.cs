using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageNumber : MonoBehaviour
{
    [SerializeField] public int ThisStage = 1; //何個目のステージなのか
    public static int ThisSt = default;
    void Start()
    {
        //SerializeFieldとstatic同時に使えなかったんでそれを回避するため
        ThisSt = ThisStage;
        Debug.Log("Thisgame" + ThisSt);
    }

    void Update()
    {
        
    }
}
