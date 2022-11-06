using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music_player : MonoBehaviour
{
    public float moveX, moveY, jumpcount, blockcount=0;
    public float jumpPower;
    Rigidbody2D rb;
    Animator an;
    int playLayer, platformLayer;
    public GameObject uigameClear;
    public score main;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        an = gameObject.GetComponent<Animator>();

        playLayer = LayerMask.NameToLayer("player");
        platformLayer = LayerMask.NameToLayer("Platform");
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        an.SetFloat("jump", Mathf.Abs(moveY));

        if (Input.GetKeyDown(KeyCode.Space) && jumpcount == 1)
        {
            moveY = 10;
            rb.AddForce(Vector2.up * moveY, ForceMode2D.Impulse);
            jumpcount = 0;
        }

        if (rb.velocity.y < 0)
        {
            Debug.DrawRay(rb.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(rb.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.3f)
                {
                    jumpcount = 1;
                    moveY = 0;
                }
            }
        }

        if (rb.velocity.y > 0)
            Physics2D.IgnoreLayerCollision(playLayer, platformLayer, true);
        else
            Physics2D.IgnoreLayerCollision(playLayer, platformLayer, false);
            
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            uigameClear.SetActive(true);
        }

        }


}

