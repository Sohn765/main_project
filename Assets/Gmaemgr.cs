using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gmaemgr : MonoBehaviour
{
    public Text talkText;
    public OP_playerMove move;
    public GameObject zz;
    public int clickcount;
    public int speed;
    void Start()
    {
        clickcount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {

        if(clickcount == 0)
        {
            zz.SetActive(true);
            talkText.text = "��.. ���� ������ ������ ���� ���Ǳ⳪ ���߰ڴ�.";
            clickcount++;
        }
        

        else if(clickcount == 1)
        {
            zz.SetActive(false);
            move.moveY = -1;
            print("�۵�Ȯ��");
        }
        
    }
}
