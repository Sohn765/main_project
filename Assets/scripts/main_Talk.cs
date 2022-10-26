using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_Talk : MonoBehaviour
{
    public Text Text;
    public int talkcount;
    public move main;
    // Start is called before the first frame update
    void Start()
    {
        talkcount = 0;
        Text.text = "어? 안녕 우현아";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (talkcount == 0)
        {
            Text.text = "여긴 어쩐일이야?";
            talkcount++;
        }
        else if (talkcount == 1)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "아니 게임프로젝트 포스터를 봤는데 같이할까 해서";
            talkcount++;
        }
        else if (talkcount == 2)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "게임프로젝트?";
            talkcount++;
        }
        else if (talkcount == 3)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "어 내가 기획한 게임이 있는데 니가 코딩을 맞아줬음 해!";
            talkcount++;
        }
        else if (talkcount == 4)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "음.. 나쁘진 않은데 대신 조건이 있어!";
            talkcount++;
        }
        else if (talkcount == 5)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "조건?";
            talkcount++;
        }
        else if (talkcount == 6)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "큰건 아닌데 내가 옛날에 만든 게임을 평가해줬으면 해!";
            talkcount++;
        }
        else if (talkcount == 7)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "그런거라면 얼마든지 해주지 어디에 있어?";
            talkcount++;
        }
        else if (talkcount == 8)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "내 옆에 있는 컴퓨터 있어";
            talkcount++;
        }
        else if (talkcount == 9)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(false);
            main.mainTalk.SetActive(false);
            main.talkmgr.SetActive(false);
            main.talkend = 1;
        }

    }

}
