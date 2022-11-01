using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class music_talk : MonoBehaviour
{
    public Text Text;
    public int talkcount;
    public move main;
    public BoxCollider2D girlgirl;
    public AudioSource AudioSource;
    public test talk;


    // Start is called before the first frame update
    private void Start()
    {
        Text.text = "우현이 안녕";
        talkcount = 0;
    }

    private void OnMouseDown()
    {
        if (main.maintalkCount == 1 && talkcount == 0)
        {
            AudioSource.Play();
            Text.text = "음악실은 뭐 하러 왔어?";
            talkcount++;
        }
        else if (talkcount == 1)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "게임을 만드려는데 사운드가 필요해";
            talkcount++;
        }
        else if (talkcount == 2)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "게임? 갑자기?";
            talkcount++;
        }
        else if (talkcount == 3)
        {

            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "응 학교에서 게임 프로젝트를 하더라고";
            talkcount++;
        }
        else if (talkcount == 4)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "아... 내가 있어야 해?";
            talkcount++;
        }
        else if (talkcount == 5)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "응 네가 필요해";
            talkcount++;
        }
        else if (talkcount == 6)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "알았어 그럼 나도 좀 도와줘";
            talkcount++;
        }
        else if (talkcount == 7)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "뭘 도와 줘?";
            talkcount++;
        }
        else if (talkcount == 8)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "애들한테 부탁받은 게임이 있는데 그거 깨면 해 줄게";
            talkcount++;
        }
        else if (talkcount == 9)
        {
            main.boy.SetActive(false);
            main.boy1.SetActive(false);
            main.mainTalk.SetActive(false);
            main.talkmgr.SetActive(false);
            main.talkend = 1;
            girlgirl.isTrigger = true;
        }

        if (main.npcCount == 1)
        {
            main.npc_Talk.SetActive(false);
            main.talkmgr.SetActive(false);
            main.npcCount--;
        }

        if (main.npcCount1 == 1)
        {
            main.npc_Talk1.SetActive(false);
            main.talkmgr.SetActive(false);
            main.npcCount1 -= 1;
        }
    }
}

