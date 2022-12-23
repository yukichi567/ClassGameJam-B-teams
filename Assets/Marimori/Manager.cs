using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    //�Q�[���J�n�A�Q�[���I�[�o�[�X�C�b�`
    [SerializeField] bool _isGame = true;

    [SerializeField]
    [Header("�o�ߎ���")]
    public float timer;
    [SerializeField]
    Text Timetext;

    [Header("�N���A�A�Q�[���I�[�o�[�摜")]
    [SerializeField]
    GameObject _gameover;
    [SerializeField]
    GameObject _gameclear;

    [Header("��script")]
    PlayerController _PC;

    // Start is called before the first frame update

    void Start()
    {
        _PC = GameObject.FindObjectOfType<PlayerController>();

        Timetext = GameObject.Find("Time").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (_isGame)
        {
            timer += Time.deltaTime;
            Timetext.text = $"{timer.ToString("F1")}";


            if (_PC.Life <= 0)
            {
                _isGame = false;
                _PC.Speed = 0;
                _PC.flipX = false;
                _gameover.gameObject.SetActive(true);
            }

            if(_PC._goal == true)
            {
                _isGame = false;
                _PC.Speed = 0;
                _PC.flipX = false;
                _gameclear.gameObject.SetActive(true);
            }

        }
    }
}
