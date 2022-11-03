using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music_player : MonoBehaviour
{
    float moveX, moveY;
    public float jumpPower;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        rb.AddForce(Vector2.right * moveX, ForceMode2D.Impulse);
    }

    void jump()
    {
        if (Input.GetKey(KeyCode.Space)) ;
    }
}
