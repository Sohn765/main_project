using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warning : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public GameObject W,M;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "warning")
        {
            W.SetActive(true);
            M.SetActive(true);
            text.text = "���� ���� �� �� �� ����";
        }

        if (collision.gameObject.tag == "warning11")
        {
            W.SetActive(true);
            M.SetActive(true);
            text.text = "��� �� ����";
        }

       
        }


    
}
