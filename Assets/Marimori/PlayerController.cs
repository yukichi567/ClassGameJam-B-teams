using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
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
    [SerializeField] public float timer;
    //HP�o�[�ݒ�
    [SerializeField] Image MaxLifeImage;
    float MaxHp = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���͂��󂯎��
        h = Input.GetAxis("Horizontal");

        // �e����͂��󂯎��
        if (Input.GetKey(KeyCode.Space) && OnField == true) jump = true;

        if (flipX)
        {
            FlipX(h);
        }

        timer += Time.deltaTime;
        MaxLifeImage.GetComponent<Image>().fillAmount = MaxHp;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.right * h * Speed, ForceMode2D.Force);

        if (jump)
        {
            this.rb.AddForce(transform.up * Jumpforce);
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

        if (timer >= 3 && collision.gameObject.CompareTag("Enemy"))
        {
            Life -= 1;
            timer = 0;
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
