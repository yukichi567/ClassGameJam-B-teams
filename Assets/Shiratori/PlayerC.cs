using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerC : MonoBehaviour
{
    Rigidbody2D rb;
    //�ړ����x
    [SerializeField] public float Speed = 0f;
    //���E���͕ϐ���
    float h;
    //�W�����v��
    [SerializeField] public float Jumpforce = 0f;
    //�W�����v�A�ڒn����
    public bool OnField;
    public bool jump;

    //���͂ɉ����č��E�𔽓]�����邩�ǂ����̃t���O
    public bool flipX = true;
    //�̗�
    [SerializeField] public float Life = 3f;
    //��e���N�[���^�C��
    public float CoolTime = 0f;
    public float timer;
    //HP�o�[�ݒ�
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
        // �e����͂��󂯎��
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

        if (G_mode)�@//�@�֐��̌Ăяo��
        {
            GM();
        }
    }
    void GM()// ���G���̏���
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
        // ���͂��󂯎��
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
         * ������͂��ꂽ��L�����N�^�[�����Ɍ�����B
         * ���E�𔽓]������ɂ́ATransform:Scale:X �� -1 ���|����B
         * Sprite Renderer �� Flip:X �𑀍삵�Ă����]����B
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
