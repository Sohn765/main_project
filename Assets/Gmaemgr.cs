using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gmaemgr : MonoBehaviour
{
    public Text talkText;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            talkText.text = "���� ������ ������ ���� ���Ǳ⳪ ���߰ڴ�.";
        }
        
    }
}
