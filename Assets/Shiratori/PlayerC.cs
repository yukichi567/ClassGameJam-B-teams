using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerC : MonoBehaviour
{
    Rigidbody2D rb;
    //移動速度
    [SerializeField] public float Speed = 0f;
    //左右入力変数ｈ
    float h;
    //ジャンプ力
    [SerializeField] public float Jumpforce = 0f;
    //ジャンプ、接地条件
    public bool OnField;
    public bool jump;

    //入力に応じて左右を反転させるかどうかのフラグ
    public bool flipX = true;
    //体力
    [SerializeField] public float Life = 3f;
    //被弾時クールタイム
    public float CoolTime = 0f;
    public float timer;
    //HPバー設定
    [SerializeField] Image MaxLifeImage;
    float MaxHp = 1f;
    // Start is called before the first frame update
    public bool G_mode;
    float speed;
    public float sp;
    float tmer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tmer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // 各種入力を受け取る
        if (Input.GetKeyDown(KeyCode.Space) && OnField == true)
        {
            jump = true;
        }
            

        if (flipX)
        {
            FlipX(h);
        }

        timer += Time.deltaTime;
        CoolTime = 0 - timer;
        MaxLifeImage.GetComponent<Image>().fillAmount = MaxHp;
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (G_mode)　//　関数の呼び出し
        {
            GM();
        }
    }
    void GM()// 無敵時の処理
    {
        tmer = tmer + Time.deltaTime;
        if (tmer > 2.0f)
        {
            G_mode = false;
            tmer = 0;
        }
    }

    private void FixedUpdate()
    {
        // 入力を受け取る
        h = Input.GetAxis("Horizontal");
        Vector2 dir = new Vector2(h, 0).normalized;
        //rb.AddForce(Vector2.right * h * Speed, ForceMode2D.Force);
        rb.velocity = dir * Speed;
        //if ()
        //{
        //    rb.velocity = dir * Speed;
        //}
        //else 
        //{

        //}
        
        if (jump)
        {
            this.rb.AddForce(Vector3.up * Jumpforce, ForceMode2D.Impulse);
            jump = false;
            OnField = false;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Field"))
        {
            OnField = true;
        }

        if (CoolTime <= 0 && collision.gameObject.CompareTag("Enemy"))
        {
            G_mode = true;
            Life -= 1;
            timer = 0;
            CoolTime = 3 - timer;
            MaxHp -= 0.33334f;
        }

    }
    void FlipX(float horizontal)
    {
        /*
         * 左を入力されたらキャラクターを左に向ける。
         * 左右を反転させるには、Transform:Scale:X に -1 を掛ける。
         * Sprite Renderer の Flip:X を操作しても反転する。
         * */
        float m_scaleX;
        m_scaleX = this.transform.localScale.x;

        if (horizontal > 0)
        {
            this.transform.localScale = new Vector3(Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
        else if (horizontal < 0)
        {
            this.transform.localScale = new Vector3(-1 * Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
    }
}
