using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OP2_mgr : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speedX, speedY;
    public GameObject show, talkmgr,why;
    public Text talk;
    Animator Animator;
    bool check;
    public int runcheckX, runcheckY,lookCount;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        speedX = rb.velocity.x;
        speedY = -1.5f;
        Animator = gameObject.GetComponent<Animator>();
        talkmgr.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (speedY != 0) runcheckY = 1;
        else runcheckY = 0;
        if (speedX != 0) runcheckX = 1;
        else runcheckX = 0;
        rb.velocity = new Vector2(speedX, speedY);
        if (runcheckX == 1) Animator.SetFloat("down", Mathf.Abs(speedY));
        if(runcheckX == 1) Animator.SetFloat("right", Mathf.Abs(speedX));
        if(speedY == 1) Animator.SetFloat("up", Mathf.Abs(speedY));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stop")
        {
            runcheckX = 0;
            speedY = rb.velocity.y;
            talk.text = "Ȯ���� ����Ķ� �׷��� ����� ����";
            show.SetActive(true);
            talkmgr.SetActive(true);
        }
        else if(collision.gameObject.tag == "find")
        {
            speedX = rb.velocity.x;
            Animator.SetFloat("right", Mathf.Abs(speedX));
            why.SetActive(true);
            StartCoroutine(wait());
            
        }
        else if (collision.gameObject.tag == "poster")
        {
            speedX = 1;
            show.SetActive(true);
            talkmgr.SetActive(true);
            talk.text = "�� ���� ������Ʈ�� �ϳ�?";
            Animator.SetFloat("stop", 1);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.0f);
        check = true;
        if (check == true)
        {
            why.SetActive(false);
            show.SetActive(true);
            talkmgr.SetActive(true);
            talk.text = "��! ���� ����?";
        }
    }
}
