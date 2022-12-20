using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goditem : MonoBehaviour
{
    GameObject playerrr;
    player pc;
    // Start is called before the first frame update
    void Start()
    {
        playerrr = GameObject.Find("player");
        pc = playerrr.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            pc.G_mode = true;
            gameObject.SetActive(false); //è¡Ç¶ÇΩïó
        }
    }
}
