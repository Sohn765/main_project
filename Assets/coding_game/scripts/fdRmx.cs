using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fdRmx : MonoBehaviour
{
    public SpriteRenderer dark;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(fadedark());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(fadeOutdark());
        }
    }

    IEnumerator fadedark()
    {
        print("실행!");
        float count = 1;
        while (count > 0)
        {
            print("반복");
            count -= 0.05f;
            yield return new WaitForSeconds(0.01f);
            dark.color = new Color(0, 0, 0, count);

        }
    }
    IEnumerator fadeOutdark()
    {
        print("실행!");
        float count = 0;
        while (count < 1.0f)
        {
            print("반복");
            count += 0.05f;
            yield return new WaitForSeconds(0.01f);
            dark.color = new Color(255, 255, 255, count);

        }
    }
}
