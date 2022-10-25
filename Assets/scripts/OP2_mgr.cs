using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OP2_mgr : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speedX, speedY;
    public GameObject show;
    public Text talk;
    Animator Animator;
    public int runclickX, runclickY;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        speedX = rb.velocity.x;
        speedY = -1.5f;
        Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speedY != 0) runclickY = 1;
        else runclickY = 0;
        if (speedX != 0) runclickX = 1;
        else runclickX = 0;
        rb.velocity = new Vector2(speedX, speedY);
        if (runclickX == 1) Animator.SetFloat("down", Mathf.Abs(speedY));
        if(runclickX == 1) Animator.SetFloat("right", Mathf.Abs(speedX));
        if(speedY == 1) Animator.SetFloat("up", Mathf.Abs(speedY));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stop")
        {
            speedY = rb.velocity.y;
            talk.text = "확실히 방과후라 그런지 사람이 없네";
            show.SetActive(true);
        }
        else if(collision.gameObject.tag == "find")
        {
            speedX = rb.velocity.x;
            show.SetActive(true);
            talk.text = "어! 저게 뭐지?";
        }
        else if (collision.gameObject.tag == "poster")
        {
            show.SetActive(true);
            talk.text = "아하 게임프로젝트 대회를 하네?";
            Animator.SetFloat("stop", 1);
        }
    }
}
