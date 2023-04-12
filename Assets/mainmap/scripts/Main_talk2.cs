using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_talk2 : MonoBehaviour
{
    public Text Text;
    public int talkcount, gameCount;
    public move main;
    public BoxCollider2D girlgirl;
    public AudioSource AudioSource;
    public test talk;
    public GameSave GameSave;

    // Start is called before the first frame update
    private void Start()
    {
        Text.text = "어땠어?";
        talkcount = 0;
    }

    private void OnMouseDown()
    {
        if (main.maintalkCount == 1 && talkcount == 0)
        {
            AudioSource.Play();
            Text.text = "나 신경 쓰지 말고 말해";
            talkcount++;
        }
        else if (talkcount == 1)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "꽤 괜찮았어 하지만...";
            talkcount++;
        }
        else if (talkcount == 2)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "하지만?";
            talkcount++;
        }
        else if (talkcount == 3)
        {

            AudioSource.Play();
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "생각보다 잔 오류가 많아";
            talkcount++;
        }
        else if (talkcount == 4)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "음... 그렇구나 다른 건?";
            talkcount++;
        }
        else if (talkcount == 5)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "다른 거? 뭔가 중력이랑 움직임이 따로 노는 거? 두개 빼곤 다 좋았어";
            talkcount++;
        }
        else if (talkcount == 6)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "흠... 그렇군 알았어! 우리 프로젝트를 만들 땐 주의해 볼게";
            talkcount++;
        }
        else if (talkcount == 7)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "고마워 그럼 난 다른 애들이랑 좀 얘기하고 올게";
            talkcount++;
        }
        else if (talkcount == 8)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "알았어";
            talkcount++;
        }
        else if (talkcount == 9)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(false);
            main.mainTalk.SetActive(false);
            main.talkmgr.SetActive(false);
            girlgirl.isTrigger = true;
            if (!PlayerPrefs.HasKey("GameClear_count"))
            {
                gameCount = 1;
            }
            else
            {
                gameCount = PlayerPrefs.GetInt("GameClear_count");
                gameCount += 1;
            }
            PlayerPrefs.SetInt("codingGameClear_count", 1);
            PlayerPrefs.SetInt("GameClear_count", gameCount);
            GameSave.progres();
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
