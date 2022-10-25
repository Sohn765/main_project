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
            talkText.text = "아.. 내일 점심은 먹을게 없네 자판기나 가야겠다.";
            clickcount++;
        }
        

        else if(clickcount == 1)
        {
            zz.SetActive(false);
            move.moveY = -1;
            print("작동확인");
        }
        
    }
}
