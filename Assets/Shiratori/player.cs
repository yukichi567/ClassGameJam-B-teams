using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float speed;
    public float sp; 
    float ho;
    public bool G_mode; //‚±‚± 
    Rigidbody2D rb;
    float tmer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tmer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        ho = Input.GetAxis("Horizontal");
        if(ho == 0)
        {
            speed = 0;
        }
        else if(ho > 0)
        {
            speed = sp;
        }
        else if(ho < 0)
        {
            speed = sp * -1;
        }
        rb.velocity = new Vector2(speed, rb.velocity.y);
        if (G_mode)@//@ŠÖ”‚ÌŒÄ‚Ño‚µ
        {
            GM();
        }
    }

    void GM()// –³“GŽž‚Ìˆ—
    {
        tmer = tmer + Time.deltaTime;
        if(tmer > 2.0f)
        {
            G_mode = false;
            tmer = 0;
        }
    }
}
